﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using YDSkyrimToolR.TranslateCore;

namespace YDSkyrimToolR.TranslateManage
{
    public class BaiDuApi
    {
        public enum BDLanguages
        {
            en=0, zh = 1, jp=2, de=3, kor = 5
        }

        public string GenerateSignature(string appId, string query, string salt, string secretKey)
        {
            // Step 1: 拼接字符串
            string rawString = appId + query + salt + secretKey;

            // Step 2: 使用MD5算法生成签名
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(rawString);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // 将字节数组转换为32位小写的十六进制字符串
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }

                return sb.ToString();
            }
        }

        public BaiduTransResult? TransStr(string Query,Languages FromLang, Languages ToLang)
        {
            BDLanguages Source = BDLanguages.en;
            BDLanguages Target = BDLanguages.zh;

            if (FromLang == Languages.English)
            {
                Source = BDLanguages.en;
            }
            if (FromLang == Languages.Chinese)
            {
                Source = BDLanguages.zh;
            }
            if (FromLang == Languages.Japanese)
            {
                Source = BDLanguages.jp;
            }
            if (FromLang == Languages.German)
            {
                Source = BDLanguages.de;
            }
            if (FromLang == Languages.Korean)
            {
                Source = BDLanguages.kor;
            }

            if (ToLang == Languages.English)
            {
                Target = BDLanguages.en;
            }
            if (ToLang == Languages.Chinese)
            {
                Target = BDLanguages.zh;
            }
            if (ToLang == Languages.Japanese)
            {
                Target = BDLanguages.jp;
            }
            if (ToLang == Languages.German)
            {
                Target = BDLanguages.de;
            }
            if (ToLang == Languages.Korean)
            {
                Target = BDLanguages.kor;
            }
            return ConstructGetRequestUrl(DeFine.GlobalLocalSetting.BaiDuAppID, Query, Source.ToString(), Target.ToString(), new Random(Guid.NewGuid().GetHashCode()).Next(100, 999).ToString(), DeFine.GlobalLocalSetting.BaiDuSecretKey);
        }

        public string Host = "https://fanyi-api.baidu.com";

        public BaiduTransResult? ConstructGetRequestUrl(string AppId, string Query, string FromLang, string ToLang, string Salt, string SecretKey)
        {
            string Sign = GenerateSignature(AppId, Query, Salt, SecretKey);
            string EncodedQuery = HttpUtility.UrlEncode(Query, Encoding.UTF8);

            string Param = $"?appid={AppId}&q={EncodedQuery}&from={FromLang}&to={ToLang}&salt={Salt}&sign={Sign}";

            string Url = Host + "/api/trans/vip/translate";
            WebHeaderCollection Headers = new WebHeaderCollection();

            HttpItem Http = new HttpItem()
            {
                URL = Url + Param,
                UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/132.0.0.0 Safari/537.36",
                Method = "Get",
                Header = Headers,
                Accept = "*/*",
                Postdata = "",
                Cookie = "",
                ContentType = "application/json; charset=utf-8",
                Timeout = 3000
            };
            try
            {
                Http.Header.Add("Accept-Encoding", " gzip");
            }
            catch { }

            var GetResult = new HttpHelper().GetHtml(Http).Html;

            if (GetResult != null)
            {
                try 
                {
                    return JsonSerializer.Deserialize<BaiduTransResult>(GetResult);
                }
                catch 
                {
                    return null;
                }
            }

            return null;
        }
    }

    public class BaiduTransResult
    {
        public string from { get; set; }
        public string to { get; set; }
        public BaiduTrans_Result[] trans_result { get; set; }
    }

    public class BaiduTrans_Result
    {
        public string src { get; set; }
        public string dst { get; set; }
    }

}
