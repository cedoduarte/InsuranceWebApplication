using InsuranceWebApplication.CQRS.Insurances.Query.GetInsuranceList;
using InsuranceWebApplication.Enums;
using InsuranceWebApplication.Models.Excel;

namespace InsuranceWebApplication.Services
{
    public interface IInsuranceExcelFileService
    {
        Task<ExcelFile> GetFileAsync(GetInsuranceListQuery query);
    }

    public class InsuranceExcelFileService : IInsuranceExcelFileService
    {
        private readonly IInsuranceService _insuranceService;

        public  InsuranceExcelFileService(IInsuranceService insuranceService)
        {
            _insuranceService = insuranceService;
        }

        public async Task<ExcelFile> GetFileAsync(GetInsuranceListQuery query)
        {
            var content = await _insuranceService.GetListAsync(query);
            if (content.TotalCount == 0)
            {
                throw new Exception("There is not content");
            }
            string temporaryFilePath = Path.GetTempFileName();
            temporaryFilePath = Path.ChangeExtension(temporaryFilePath, ".xlsx");
            using (var workbook = new NPOI.XSSF.UserModel.XSSFWorkbook())
            {
                var sheet = workbook.CreateSheet("Insurances");
                int iRow = 0;
                var row = sheet.CreateRow(iRow);
                row.CreateCell(0).SetCellValue("Id");
                row.CreateCell(1).SetCellValue("Start date");
                row.CreateCell(2).SetCellValue("End date");
                row.CreateCell(3).SetCellValue("Type");
                row.CreateCell(4).SetCellValue("Premium");
                row.CreateCell(5).SetCellValue("Status");
                row.CreateCell(6).SetCellValue("User Id");
                row.CreateCell(7).SetCellValue("First name");
                row.CreateCell(8).SetCellValue("Last name");
                row.CreateCell(9).SetCellValue("Email");
                row.CreateCell(10).SetCellValue("Car Id");
                row.CreateCell(11).SetCellValue("Model");
                row.CreateCell(12).SetCellValue("Color");
                row.CreateCell(13).SetCellValue("Price");
                row.CreateCell(14).SetCellValue("Plate number");
                row.CreateCell(15).SetCellValue("Last modified");
                row.CreateCell(16).SetCellValue("Last created");
                for (int iInsurance = 0; iInsurance < content.InsuranceList!.Count; iInsurance++)
                {
                    iRow++;
                    row = sheet.CreateRow(iInsurance);
                    row.CreateCell(0).SetCellValue(content.InsuranceList![iInsurance].Id);
                    row.CreateCell(1).SetCellValue(content.InsuranceList![iInsurance].StartDate.ToString());
                    row.CreateCell(2).SetCellValue(content.InsuranceList![iInsurance].EndDate.ToString());
                    row.CreateCell(3).SetCellValue(content.InsuranceList![iInsurance].TypeOfInsurance);
                    row.CreateCell(4).SetCellValue((double)content.InsuranceList![iInsurance].Premium!);
                    row.CreateCell(5).SetCellValue(Enum.GetName(typeof(InsuranceStatus), content.InsuranceList![iInsurance].Status!));
                    row.CreateCell(6).SetCellValue(content.InsuranceList![iInsurance].UserId);
                    row.CreateCell(7).SetCellValue(content.InsuranceList![iInsurance].FirstName);
                    row.CreateCell(8).SetCellValue(content.InsuranceList![iInsurance].LastName);
                    row.CreateCell(9).SetCellValue(content.InsuranceList![iInsurance].Email);
                    row.CreateCell(10).SetCellValue(content.InsuranceList![iInsurance].CarId);
                    row.CreateCell(11).SetCellValue(content.InsuranceList![iInsurance].Model);
                    row.CreateCell(12).SetCellValue(content.InsuranceList![iInsurance].Color);
                    row.CreateCell(13).SetCellValue((double)content.InsuranceList![iInsurance].Price!);
                    row.CreateCell(14).SetCellValue(content.InsuranceList![iInsurance].PlateNumber);
                    row.CreateCell(15).SetCellValue(content.InsuranceList![iInsurance].LastModified.ToString());
                    row.CreateCell(16).SetCellValue(content.InsuranceList![iInsurance].LastCreated.ToString());
                }
                using (var fileStream = new FileStream(temporaryFilePath, FileMode.Create, FileAccess.Write))
                {
                    workbook.Write(fileStream);
                }
            }
            var excelFile = new ExcelFile()
            {
                FileName = "insurances.xlsx",
                AcceptHeader = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                Bytes = await System.IO.File.ReadAllBytesAsync(temporaryFilePath)
            };
            System.IO.File.Delete(temporaryFilePath);
            return excelFile;
        }
    }
}
