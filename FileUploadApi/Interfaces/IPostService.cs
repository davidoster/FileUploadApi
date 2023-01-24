using FileUploadApi.Requests;
using FileUploadApi.Response;

namespace FileUploadApi.Interfaces
{
    public interface IPostService
    {
        Task<FileStream> GetPostImageAsync(int id);
        Task SavePostImageAsync(PostRequest postRequest);
        Task<PostResponse> CreatePostAsync(PostRequest postRequest);
    }
}