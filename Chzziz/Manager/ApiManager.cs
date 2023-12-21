using System.Net.Http.Json;
using Chzziz.Models.Api;

namespace Chzziz.Manager;

public class ApiManager : IDisposable {
    private HttpClient Client = new HttpClient();
    
    async Task<ChzzkResponse<LiveDetailContent>> GetDetails(string streamerId) {
        var response = await Client.GetAsync($"https://api.chzzk.naver.com/service/v1/channels/{streamerId}/live-detail");
        return response.Content.ReadFromJsonAsync<ChzzkResponse<LiveDetailContent>>().Result!;
    } 
    
    async Task<ChzzkResponse<LiveStatusContent>> Check(string streamerId) {
        var response = await Client.GetAsync($"https://api.chzzk.naver.com/polling/v1/channels/{streamerId}/live-status");
        return response.Content.ReadFromJsonAsync<ChzzkResponse<LiveStatusContent>>().Result!;
    }

    public void Dispose() {
        Client.Dispose();
    }
}