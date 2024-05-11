using System.Data;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Text;
using System.Net.Http.Headers;

interface post_to_wb 
{
    public Task add_to_backet(string POSTurl, string POSTcontent);
}
internal class Program:post_to_wb
{
    public async Task add_to_backet(string POSTurl,string POSTcontent)
    {
        Console.WriteLine("Hello, World!");
        HttpClientHandler clientHandler = new HttpClientHandler();
        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        httpClient = new HttpClient(clientHandler);

        httpClient = new HttpClient(clientHandler);
        var content = new StringContent(POSTcontent);
        httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJpYXQiOjE3MTUyNzkyNTIsInZlcnNpb24iOjIsInVzZXIiOiI2MDc2Nzc4OSIsInNoYXJkX2tleSI6IjMwIiwiY2xpZW50X2lkIjoid2IiLCJzZXNzaW9uX2lkIjoiOGM4YTgyYWU4OTY2NGVkODhiNGFlNWUxMzM4NmY4ZWMiLCJ1c2VyX3JlZ2lzdHJhdGlvbl9kdCI6MTY4NTEzMzc3MywidmFsaWRhdGlvbl9rZXkiOiJlNjE5OWQ3NDk0ZmUzMDFlYzIzNDI3ZWMxOGUyMzAyOTg2NGRiZWUwMDU1MWNkNDU3NzI2YjlmYjM1YjdmY2UyIiwicGhvbmUiOiJ1TlArSysvdU1ySFNPU01rWkUydXBRPT0ifQ.VZqS80PjNvuiA_CCggBBGAYAjs7v8HonrbqNhNUEiQ_lttPhApUHCr3RhirfgPWkY6xOgo1Tw44cO5FJCTgccVGkMAT-y9-8L8tdMvPhuhRUUGaQV3xE5khdq56skAgJZ-JuojMViuqKsGXOMvmw-k96ZE3jJQkHdWGYJXhrysoOvgpO91EBR2pdIuHKt3VbCtw_M7KmrCXLZgf9-3UV3RGOj33vKq390GJDG34QFEMDcevEav2GIyzqMNyv8YpWiAD2GQy6CquooZkJlWvUoksr-0OTGCSHdpJEcIG_kdPVGxPfy3DqJaFLj_bNXXDHcYjz-iGYGjiYhFZRyTuRWw");

        httpClient.DefaultRequestHeaders.Add("Accept", "*/*");
        httpClient.DefaultRequestHeaders.Add("Accept-Encoding", "gzip,deflate,br,zstd");
        httpClient.DefaultRequestHeaders.Add("Accept-Language", "ru-RU,ru;q=0.9,en-US;q=0.8,en;q=0.7");
        httpClient.DefaultRequestHeaders.Add("Connection", "keep-alive");
        content.Headers.Add("Content-Length", "131");
        content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
        httpClient.DefaultRequestHeaders.Add("Host", "a.wb.ru");
        httpClient.DefaultRequestHeaders.Add("Origin", "https://www.wildberries.ru");
        httpClient.DefaultRequestHeaders.Add("Referer", "https://www.wildberries.ru/");
        httpClient.DefaultRequestHeaders.Add("Sec-Ch-Ua", "\"OperaGX\";v=\"109\",\"Not:A-Brand\";v=\"8\",\"Chromium\";v=\"123\"");
        httpClient.DefaultRequestHeaders.Add("Sec-Ch-Ua-Mobile", "?0");
        httpClient.DefaultRequestHeaders.Add("Sec-Ch-Ua-Platform", "Windows");
        httpClient.DefaultRequestHeaders.Add("Sec-Fetch-Dest", "empty");
        httpClient.DefaultRequestHeaders.Add("Sec-Fetch-Mode", "cors");
        httpClient.DefaultRequestHeaders.Add("Sec-Fetch-Site", "same-site");
        httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/123.0.0.0 Safari/537.36 OPR/109.0.0.0");

        using var response2 = await httpClient.PostAsync(POSTurl, content);
        string responseText = await response2.Content.ReadAsStringAsync();
        Console.WriteLine(response2.StatusCode + " " + responseText);
    }

    static HttpClient? httpClient;

    private static async Task Main(string[] args) 
    { 
        Program pr=new Program();
        await pr.add_to_backet(
            "https://cart-storage-api.wildberries.ru/api/basket/sync?ts=1715293108516&device_id=site_c45aad1927b14a25b94c5b5deead47fe",
            "[{\"chrt_id\":328676704,\"quantity\":1,\"cod_1s\":204200891,\"client_ts\":1715350594,\"op_type\":1,\"target_url\":\"EX|1|MCS|CR|popular||||||\"}]"); 
    }
}