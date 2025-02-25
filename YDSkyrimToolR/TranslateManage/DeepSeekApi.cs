﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Net;
using System.Security.Cryptography.Pkcs;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.Json;

namespace YDSkyrimToolR.TranslateManage
{

    public class DeepSeekItem
    {
        public string model { get; set; }
        public List<DeepSeekMessage> messages { get; set; }
        public bool stream { get; set; }
    }

    public class DeepSeekMessage
    {
        public string role { get; set; }
        public string content { get; set; }

        public DeepSeekMessage(string role, string content)
        {
            this.role = role;
            this.content = content;
        }
    }


    public class DeepSeekRootobject
    {
        public string id { get; set; }
        public string _object { get; set; }
        public int created { get; set; }
        public string model { get; set; }
        public DeepSeekChoice[] choices { get; set; }
        public DeepSeekUsage usage { get; set; }
        public string system_fingerprint { get; set; }
    }

    public class DeepSeekUsage
    {
        public int prompt_tokens { get; set; }
        public int completion_tokens { get; set; }
        public int total_tokens { get; set; }
        public DeepSeekPrompt_Tokens_Details prompt_tokens_details { get; set; }
        public int prompt_cache_hit_tokens { get; set; }
        public int prompt_cache_miss_tokens { get; set; }
    }

    public class DeepSeekPrompt_Tokens_Details
    {
        public int cached_tokens { get; set; }
    }

    public class DeepSeekChoice
    {
        public int index { get; set; }
        public DeepSeekRMessage message { get; set; }
        public object logprobs { get; set; }
        public string finish_reason { get; set; }
    }

    public class DeepSeekRMessage
    {
        public string role { get; set; }
        public string content { get; set; }
    }


    public class DeepSeekApi
    {
        public string QuickTrans(string TransSource)
        {
            var GetTransSource = string.Format("{0} 翻译到中文 接口只返回结果", TransSource);
            var GetResult = CallAI(GetTransSource);
            string CNStr = "";
            if (GetResult.choices.Length > 0)
            {
                CNStr = GetResult.choices[0].message.content.Trim(); 
            }
            if (CNStr.Trim().Length > 0)
            {
                return CNStr;
            }
            else
            {
                return string.Empty;
            }
        }

        public DeepSeekRootobject CallAI(string Msg)
        {
            DeepSeekItem NDeepSeekItem = new DeepSeekItem();
            NDeepSeekItem.model = "deepseek-chat";
            NDeepSeekItem.messages = new List<DeepSeekMessage>();
            NDeepSeekItem.messages.Add(new DeepSeekMessage("user", Msg));
            NDeepSeekItem.stream = false;
            return CallAI(NDeepSeekItem);
        }

        public DeepSeekRootobject CallAI(DeepSeekItem Item)
        {
            string GetJson = JsonSerializer.Serialize(Item);
            WebHeaderCollection Headers = new WebHeaderCollection();
            Headers.Add("Authorization", string.Format("Bearer {0}", DeFine.GlobalLocalSetting.DeepSeekKey));
            HttpItem Http = new HttpItem()
            {
                URL = "https://api.deepseek.com/chat/completions",
                UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/132.0.0.0 Safari/537.36",
                Method = "Post",
                Header = Headers,
                Accept = "*/*",
                Postdata = GetJson,
                Cookie = "",
                ContentType = "application/json",
                Timeout = 3000
            };
            try
            {
                Http.Header.Add("Accept-Encoding", " gzip");
            }
            catch { }

            string GetResult = new HttpHelper().GetHtml(Http).Html;
            
            return JsonSerializer.Deserialize<DeepSeekRootobject>(GetResult);
        }
    }
}
