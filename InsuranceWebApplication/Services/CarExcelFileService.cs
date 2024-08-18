using InsuranceWebApplication.CQRS.Cars.Query.GetCarList;
using InsuranceWebApplication.Models.Excel;

namespace InsuranceWebApplication.Services
{
    public interface ICarExcelFileService
    {
        Task<ExcelFile> GetFileAsync(GetCarListQuery query);
    }

    public class CarExcelFileService : ICarExcelFileService
    {
        private readonly ICarService _carService;

        public CarExcelFileService(ICarService carService)
        {
            _carService = carService;
        }

        public async Task<ExcelFile> GetFileAsync(GetCarListQuery query)
        {
            var content = await _carService.GetListAsync(query);
            string temporaryFilePath = Path.GetTempFileName();
            temporaryFilePath = Path.ChangeExtension(temporaryFilePath, ".xlsx");
            using (var workbook = new NPOI.XSSF.UserModel.XSSFWorkbook())
            {
                var sheet = workbook.CreateSheet("Cars");
                int iRow = 0;
                var row = sheet.CreateRow(iRow);
                row.CreateCell(0).SetCellValue("Id");
                row.CreateCell(1).SetCellValue("Model");
                row.CreateCell(2).SetCellValue("Color");
                row.CreateCell(3).SetCellValue("Price");
                row.CreateCell(4).SetCellValue("Plate number");
                row.CreateCell(5).SetCellValue("Last modified");
                row.CreateCell(6).SetCellValue("Last created");
                for (int iCar = 0; iCar < content.CarList!.Count; iCar++)
                {
                    ++iRow;
                    row = sheet.CreateRow(iRow);
                    row.CreateCell(0).SetCellValue(content.CarList![iCar].Id);
                    row.CreateCell(1).SetCellValue(content.CarList![iCar].Model);
                    row.CreateCell(2).SetCellValue(content.CarList![iCar].Color);
                    row.CreateCell(3).SetCellValue((double)content.CarList![iCar].Price!);
                    row.CreateCell(4).SetCellValue(content.CarList![iCar].PlateNumber);
                    row.CreateCell(5).SetCellValue(content.CarList![iCar].LastModified.ToString());
                    row.CreateCell(6).SetCellValue(content.CarList![iCar].LastCreated.ToString());
                }
                using (var fileStream = new FileStream(temporaryFilePath, FileMode.Create, FileAccess.Write))
                {
                    workbook.Write(fileStream);
                }
            }
            var excelFile = new ExcelFile()
            {
                FileName = "cars.xlsx",
                AcceptHeader = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                Bytes = await System.IO.File.ReadAllBytesAsync(temporaryFilePath)
            };
            System.IO.File.Delete(temporaryFilePath);
            return excelFile;
        }
    }
}
