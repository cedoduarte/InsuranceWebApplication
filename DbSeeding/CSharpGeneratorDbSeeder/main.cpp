#include <QCoreApplication>
#include <QJsonDocument>
#include <QJsonObject>
#include <QJsonArray>
#include <QJsonValue>
#include <QFile>
#include <QDebug>
#include <QTextStream>

QByteArray readFile(const QString &filePath)
{
    QFile file(filePath);
    file.open(QIODevice::ReadOnly | QIODevice::Text);
    QByteArray result = file.readAll();
    file.close();
    return result;
}

void writeFile(const QString &filePath, const QString &content)
{
    QFile file(filePath);
    file.open(QIODevice::WriteOnly | QIODevice::Text);
    QTextStream out(&file);
    out << content;
    file.flush();
    file.close();
}

QString getCodeForInsurances()
{
    QJsonDocument doc = QJsonDocument::fromJson(readFile(":/input/insurances.json"));
    QJsonArray array = doc.array();
    int i = 0;
    QJsonObject insurance = array[i].toObject();
    QString code;
    code += QString("new Insurance()\n"
                    "{\n"
                    "UserId = %1,\n"
                    "CarId = %2,\n"
                    "StartDate = %3,\n"
                    "EndDate = %4,\n"
                    "TypeOfInsurance = \"%5\",\n"
                    "Premium = %6m,\n"
                    "Status = %7,\n"
                    "LastModified = %8,\n"
                    "IsDeleted = %9,\n"
                    "LastDeleted = %10\n"
                    "}").arg(insurance["UserId"].toString(),
                     insurance["CarId"].toString(),
                     insurance["StartDate"].toString(),
                     insurance["EndDate"].toString(),
                     insurance["TypeOfInsurance"].toString(),
                     insurance["Premium"].toString().toLower(),
                     insurance["Status"].toString(),
                     insurance["LastModified"].toString(),
                     insurance["IsDeleted"].toString().toLower(),
                     insurance["LastDeleted"].toString());
    for (i = 1; i < array.count(); i++)
    {
        insurance = array[i].toObject();
        code += QString("\n,new Insurance()\n"
                        "{\n"
                        "UserId = %1,\n"
                        "CarId = %2,\n"
                        "StartDate = %3,\n"
                        "EndDate = %4,\n"
                        "TypeOfInsurance = \"%5\",\n"
                        "Premium = %6m,\n"
                        "Status = %7,\n"
                        "LastModified = %8,\n"
                        "IsDeleted = %9,\n"
                        "LastDeleted = %10\n"
                        "}").arg(insurance["UserId"].toString(),
                         insurance["CarId"].toString(),
                         insurance["StartDate"].toString(),
                         insurance["EndDate"].toString(),
                         insurance["TypeOfInsurance"].toString(),
                         insurance["Premium"].toString().toLower(),
                         insurance["Status"].toString(),
                         insurance["LastModified"].toString(),
                         insurance["IsDeleted"].toString().toLower(),
                         insurance["LastDeleted"].toString());
    }
    return code;
}

QString getCodeForUsers()
{
    QJsonDocument doc = QJsonDocument::fromJson(readFile(":/input/users.json"));
    QJsonArray array = doc.array();
    int i = 0;
    QJsonObject user = array[i].toObject();
    QString code;
    code += QString("new User()\n"
                    "{\n"
                    "FirstName = \"%1\",\n"
                    "LastName = \"%2\",\n"
                    "Email = \"%3\",\n"
                    "PasswordHash = \"%4\",\n"
                    "LastModified = %5,\n"
                    "IsDeleted = %6,\n"
                    "LastDeleted = %7\n"
                    "}").arg(user["FirstName"].toString(),
                     user["LastName"].toString(),
                     user["Email"].toString(),
                     user["PasswordHash"].toString(),
                     user["LastModified"].toString(),
                     user["IsDeleted"].toString().toLower(),
                     user["LastDeleted"].toString());
    for (i = 1; i < array.count(); i++)
    {
        user = array[i].toObject();
        code += QString("\n,new User()\n"
                        "{\n"
                        "FirstName = \"%1\",\n"
                        "LastName = \"%2\",\n"
                        "Email = \"%3\",\n"
                        "PasswordHash = \"%4\",\n"
                        "LastModified = %5,\n"
                        "IsDeleted = %6,\n"
                        "LastDeleted = %7\n"
                        "}").arg(user["FirstName"].toString(),
                         user["LastName"].toString(),
                         user["Email"].toString(),
                         user["PasswordHash"].toString(),
                         user["LastModified"].toString(),
                         user["IsDeleted"].toString().toLower(),
                         user["LastDeleted"].toString());
    }
    return code;
}

QString getCodeForCars()
{
    QJsonDocument doc = QJsonDocument::fromJson(readFile(":/input/cars.json"));
    QJsonArray array = doc.array();
    int i = 0;
    QJsonObject car = array[i].toObject();
    QString code;
    code += QString("new Car()\n"
                    "{\n"
                    "Model = \"%1\",\n"
                    "Color = \"%2\",\n"
                    "Price = %3m,\n"
                    "PlateNumber = \"%4\",\n"
                    "LastModified = %5,\n"
                    "IsDeleted = %6,\n"
                    "LastDeleted = %7\n"
                    "}").arg(car["Model"].toString(),
                     car["Color"].toString(),
                     car["Price"].toString(),
                     car["PlateNumber"].toString(),
                     car["LastModified"].toString(),
                     car["IsDeleted"].toString().toLower(),
                     car["LastDeleted"].toString());
    for (i = 1; i < array.count(); i++)
    {
        car = array[i].toObject();
        code += QString("\n,new Car()\n"
                        "{\n"
                        "Model = \"%1\",\n"
                        "Color = \"%2\",\n"
                        "Price = %3m,\n"
                        "PlateNumber = \"%4\",\n"
                        "LastModified = %5,\n"
                        "IsDeleted = %6,\n"
                        "LastDeleted = %7\n"
                        "}").arg(car["Model"].toString(),
                         car["Color"].toString(),
                         car["Price"].toString(),
                         car["PlateNumber"].toString(),
                         car["LastModified"].toString(),
                         car["IsDeleted"].toString().toLower(),
                         car["LastDeleted"].toString());
    }
    return code;
}

int main(int argc, char *argv[])
{
    QCoreApplication a(argc, argv);
    writeFile("insurances.cs", getCodeForInsurances());
    writeFile("users.cs", getCodeForUsers());
    writeFile("cars.cs", getCodeForCars());
    qDebug() << "done!";
    return a.exec();
}
