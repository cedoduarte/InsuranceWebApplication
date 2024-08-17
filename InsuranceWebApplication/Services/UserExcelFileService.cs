using InsuranceWebApplication.CQRS.Users.Query.GetUserList;
using InsuranceWebApplication.Models.Excel;
using NPOI.SS.UserModel;

namespace InsuranceWebApplication.Services
{
    public interface IUserExcelFileService 
    {
        Task<ExcelFile> GetFileAsync(GetUserListQuery query);
    }

    public class UserExcelFileService : IUserExcelFileService
    {
        private readonly IUserService _userService;

        public UserExcelFileService(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<ExcelFile> GetFileAsync(GetUserListQuery query)
        {
            var content = await _userService.GetListAsync(query);
            string temporaryFilePath = Path.GetTempFileName();
            temporaryFilePath = Path.ChangeExtension(temporaryFilePath, ".xlsx");
            using (var workbook = new NPOI.XSSF.UserModel.XSSFWorkbook())
            {
                var sheet = workbook.CreateSheet("Users");
                int iRow = 0;
                var row = sheet.CreateRow(iRow);
                row.CreateCell(0).SetCellValue("Id");
                row.CreateCell(1).SetCellValue("First name");
                row.CreateCell(2).SetCellValue("Last name");
                row.CreateCell(3).SetCellValue("Email");
                row.CreateCell(4).SetCellValue("Last modified");
                row.CreateCell(5).SetCellValue("Last created");
                for (int iUser = 0; iUser < content.UserList!.Count; iUser++)
                {
                    ++iRow;
                    row = sheet.CreateRow(iRow);
                    row.CreateCell(0).SetCellValue(content.UserList![iUser].Id);
                    row.CreateCell(1).SetCellValue(content.UserList![iUser].FirstName);
                    row.CreateCell(2).SetCellValue(content.UserList![iUser].LastName);
                    row.CreateCell(3).SetCellValue(content.UserList![iUser].Email);
                    row.CreateCell(4).SetCellValue(content.UserList![iUser].LastModified.ToString());
                    row.CreateCell(5).SetCellValue(content.UserList![iUser].LastCreated.ToString());
                }
                using (var fileStream = new FileStream(temporaryFilePath, FileMode.Create, FileAccess.Write))
                {
                    workbook.Write(fileStream);
                }
            }
            var excelFile = new ExcelFile()
            {
                FileName = "users.xlsx",
                AcceptHeader = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                Bytes = await System.IO.File.ReadAllBytesAsync(temporaryFilePath)
            };
            System.IO.File.Delete(temporaryFilePath);
            return excelFile;
        }
    }
}
