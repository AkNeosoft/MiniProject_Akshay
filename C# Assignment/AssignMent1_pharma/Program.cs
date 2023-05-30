using System;
using System.Globalization;
using System.Xml.Linq;

public class Boxing
{
    public static void Main(string[] args)
    {
        Medicine med = new Medicine("001","Dolo","Akshay","ASD","1000","22/05/2023","22/05/2024","1234");
        med.display();

        Sales sales = new Sales();
    }

    public class Medicine
    {
        public string MedicineCode { get; set; }
        public string MedicineName { get; set; }

        public string ManufacturarName { get; set; }

        public string UnitPrice { get; set; }

        public string QuantityOnhand { get; set; }

        public string ManufactureDdate { get; set; }

        public string ExpiryDate { get; set; }

        public string BatchNumber { get; set; }


        public Medicine(string medcode,string medname, string manufaturename, string unitprice,string quantity, string manufaturedate,string expiry, string batchnumber)
        {

            Accept(medcode,medname,manufaturename,unitprice,quantity, manufaturedate,expiry,batchnumber);
            

        }
        public void Accept(string medcode, string medname, string manufaturename, string unitprice, string quantity, string manufaturedate, string expiry, string batchnumber)
        {
            MedicineCode = medcode;
            MedicineName = medname;
            ManufacturarName = manufaturename;
            UnitPrice = unitprice;
            QuantityOnhand = quantity;
            ManufactureDdate = manufaturedate;
            ExpiryDate = expiry;
            BatchNumber = batchnumber;
        }

        public void display()
        {
            Console.WriteLine(MedicineCode + " " + MedicineName + " " + ManufacturarName + " " + UnitPrice + " " + QuantityOnhand + " " + ExpiryDate + " " + BatchNumber);
        }

    }

    public class Sales
    {

    }
}
