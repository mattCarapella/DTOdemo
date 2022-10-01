using Microsoft.AspNetCore.Components.Forms;

namespace DTOdemo_SERVER.Service.IService;

public interface IFileUpload
{
    Task<string> UploadFile(IBrowserFile file);

    bool DeleteFile(string filePath);

}