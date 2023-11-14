using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using CruelWorld.Account;
using MyNameIsGiorgio.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CruelWorld
{
    public class RequestService
    {
        private const string GameVersion = "1.269";
        private int _currentRequestId = 12;

        //  private readonly string _proxyUri = "http://:8000";

        public int currentRequestId
        {
            get => _currentRequestId;
            set { _currentRequestId = +value; }
        }

        public void StartupRequestIdSet(int value)
        {
            _currentRequestId = value;
        }

        public async Task<string> SendRequest(AccountParams accountParams, Payload payload)
        {
            var tcs = new TaskCompletionSource<bool>();
            await RequestQueueService.AddRequestToQueue(tcs);
            var webRequest = (HttpWebRequest) WebRequest.Create(accountParams.RequestsAddress);

            var encryptor = new Encryptor(accountParams.UserKey);

            byte[] payloadBody = Encoding.ASCII.GetBytes(payload.ToString());

            Console.WriteLine(payload.ToString());

            webRequest.AutomaticDecompression =
                DecompressionMethods.All;
            webRequest.Method = "POST";
            webRequest.ContentType = "application/json";
            webRequest.KeepAlive = true;
            webRequest.Accept = "*/*";
            webRequest.Host = accountParams.Domain;
            webRequest.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);

            webRequest.Headers["Client-Identification"] =
                $"version={GameVersion}; requiredVersion={GameVersion}; platform=bro; platformType=html5; platformVersion=web";
            webRequest.Headers["Origin"] = accountParams.origin;
            webRequest.Headers["Signature"] = (encryptor.getEncryptedData(payload));
            webRequest.UserAgent =
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36";
            webRequest.Referer = $"https://{accountParams.region}.forgeofempires.com/game/index?";
            webRequest.Headers["Accept-Encoding"] = "gzip, deflate, br";
            webRequest.Headers["Accept-Language"] = "en-US,en;q=0.9";
            webRequest.Headers["Cookie"] =
                // $"instanceId={accountParams.instanceId};" +
                $" sid={accountParams.sid};"
                //  + $" cid={accountParams.cid};"
                //  + $" ig_conv_last_site={accountParams.ig_conv_last_site};" +
                // $" _uetsid={accountParams._uetsid};" +
                // $" _uetvid={accountParams._uetvid}"
                ;
            webRequest.Headers["sec-ch-ua"] =
                "\"Google Chrome\";v=\"114\", \"Not(A:Brand\";v=\"8\", \"Chromium\";v=\"114\"";
            webRequest.Headers["sec-ch-ua-mobile"] = "?0";
            webRequest.Headers["sec-ch-ua-platform"] = "\"Windows\"";
            webRequest.Headers["sec-fetch-dest"] = "empty";
            webRequest.Headers["sec-fetch-mode"] = "cors";
            webRequest.Headers["sec-fetch-site"] = "same-origin";

            Task<string> Response;
            using (Stream requestStream = await webRequest.GetRequestStreamAsync())
            {
                await requestStream.WriteAsync(payloadBody, 0, payloadBody.Length);
                await requestStream.FlushAsync();
            }

            using (var response = (HttpWebResponse) await webRequest.GetResponseAsync())
            using (Stream streamResponse = response.GetResponseStream())
            using (StreamReader streamReader = new StreamReader(streamResponse, Encoding.Default))
            {
                Response = streamReader.ReadToEndAsync();
                var x = Response.Result;
                // Console.WriteLine(x);
            }

            currentRequestId += 1;
            if (!tcs.Task.IsCompleted)
            {
                tcs.SetResult(true);
            }

            return await Response;
        }
    }
}