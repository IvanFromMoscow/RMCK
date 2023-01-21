using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using BL;
using System.Linq;
namespace OrderMemory
{
    public class CompanyRepository : ICompanyRepository
    {
        private string _path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "config.xml");
        private List<Company> _companies;
        public CompanyRepository()
        {
            GetCompanies();

        }
        public Company Get(int id)
        {
            if (_companies != null)
            {
                return _companies.FirstOrDefault(c => c.Id == id);
            }
            else
            {
                throw new NullReferenceException(nameof(_companies));
            }
        }
        public List<Company> GetAll()
        {
            return _companies;
        }
        private void GetCompanies()
        {
            _companies = new List<Company>();
            if (File.Exists(_path))
            {
                XDocument xDoc = XDocument.Load(_path);
                XElement? xRoot = xDoc.Element("ArrayOfCompany");
                if (xRoot != null)
                {
                    foreach (XElement company in xRoot.Elements("Company"))
                    {
                        //Console.WriteLine(company.Element("Id").Value);
                        _companies.Add(GetCompanyByStringParameters(company));


                    }
                }
            }

        }
        private Company GetCompanyByStringParameters(XElement item)
        {
            Byte.TryParse(item.Element("Id")?.Value, out byte id);
            var n = item.Element("Name").Value;
            Decimal.TryParse(item.Element("Price").Value.ToString(), out decimal price);
            Double.TryParse(item.Element("OHZ").Value, out double ohz);
            Double.TryParse(item.Element("OPZ").Value, out double opz);
            if(id != null && !string.IsNullOrEmpty(n) && price != null && ohz != null && opz != null)
            {
                return new Company(id, n, price, ohz, opz);
            }
            return null;
        }
    }
}
