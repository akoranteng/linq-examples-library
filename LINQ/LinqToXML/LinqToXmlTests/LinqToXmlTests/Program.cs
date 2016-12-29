using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXmlTests
{
	class Program
	{
		static void Main(string[] args)
		{
			AddProcessingInstruction();
		}

		private static void BuildBasicXmlDocument()
		{
			XDocument bandsDocument = new XDocument(
				new XElement("Bands",
					new XElement("Band",
						new XAttribute("genre", "rock"),
						new XElement("Name", "Queen"),
						new XElement("NumberOfMembers", 4)),
					new XElement("Band",
						new XAttribute("genre", "progressive"),
						new XElement("Name", "Genesis"),
						new XElement("NumberOfMembers", 5)),
					new XElement("Band",
						new XAttribute("genre", "metal"),
						new XElement("Name", "Metallica"),
						new XElement("NumberOfMembers", 4))));

			Debug.WriteLine(bandsDocument);
			Console.ReadKey();
		}

		private static void AddProcessingInstruction()
		{
			XDocument bandsDocument = new XDocument(
				new XProcessingInstruction("xml-stylesheet", "mystyle.css"),
				new XElement("Bands",
					new XElement("Band",
						new XAttribute("genre", "rock"),
						new XElement("Name", "Queen"),
						new XElement("NumberOfMembers", 4)),
					new XElement("Band",
						new XAttribute("genre", "progressive"),
						new XElement("Name", "Genesis"),
						new XElement("NumberOfMembers", 5)),
					new XElement("Band",
						new XProcessingInstruction("comment", "this-is-a-comment"),
						new XAttribute("genre", "metal"),
						new XElement("Name", "Metallica"),
						new XElement("NumberOfMembers", 4))));
			Debug.WriteLine(bandsDocument.ToString());

XDocument bandsDocument2 = new XDocument(
	new XElement("Bands",
		new XElement("Band",
			new XAttribute("genre", "rock"),
			new XElement("Name", "Queen"),
			new XElement("NumberOfMembers", 4)),
		new XElement("Band",
			new XAttribute("genre", "progressive"),
			new XElement("Name", "Genesis"),
			new XElement("NumberOfMembers", 5)),
		new XElement("Band",
			new XAttribute("genre", "metal"),
			new XElement("Name", "Metallica"),
			new XElement("NumberOfMembers", 4))));
bandsDocument2.AddFirst(new XProcessingInstruction("comment", "this-is-some-comment"));

			Console.ReadKey();
		}

		private static void AddDeclaration()
		{
			XDocument bandsDocument = new XDocument(
				new XDeclaration("1.0", "UTF-8", "yes"),
				new XElement("Bands",
					new XElement("Band",
						new XAttribute("genre", "rock"),
						new XElement("Name", "Queen"),
						new XElement("NumberOfMembers", 4)),
					new XElement("Band",
						new XAttribute("genre", "progressive"),
						new XElement("Name", "Genesis"),
						new XElement("NumberOfMembers", 5)),
					new XElement("Band",
						new XAttribute("genre", "metal"),
						new XElement("Name", "Metallica"),
						new XElement("NumberOfMembers", 4))));

			XDocument bandsDocument2 = new XDocument(
				new XElement("Bands",
					new XElement("Band",
						new XAttribute("genre", "rock"),
						new XElement("Name", "Queen"),
						new XElement("NumberOfMembers", 4)),
					new XElement("Band",
						new XAttribute("genre", "progressive"),
						new XElement("Name", "Genesis"),
						new XElement("NumberOfMembers", 5)),
					new XElement("Band",
						new XAttribute("genre", "metal"),
						new XElement("Name", "Metallica"),
						new XElement("NumberOfMembers", 4))));
			bandsDocument2.Declaration = new XDeclaration("1.0", "UTF-8", "yes");

			Debug.WriteLine(bandsDocument.Declaration + Environment.NewLine + bandsDocument.ToString());
			Console.ReadKey();
		}

		private static void AddNamespace()
		{
			XNamespace xNamespace = @"http:\\www.mycompany.com\domains\music\";
			XDocument bandsDocument = new XDocument(
				new XElement(xNamespace + "Bands",
					new XAttribute(XNamespace.Xmlns + "domain", xNamespace),
					new XElement(xNamespace + "Band",
						new XAttribute("genre", "rock"),
						new XElement(xNamespace + "Name", "Queen"),
						new XElement(xNamespace + "NumberOfMembers", 4)),
					new XElement(xNamespace + "Band",
						new XAttribute("genre", "progressive"),
						new XElement(xNamespace + "Name", "Genesis"),
						new XElement(xNamespace + "NumberOfMembers", 5)),
					new XElement(xNamespace + "Band",
						new XAttribute("genre", "metal"),
						new XElement(xNamespace + "Name", "Metallica"),
						new XElement(xNamespace + "NumberOfMembers", 4))));



			Debug.WriteLine(bandsDocument);
			Console.ReadKey();
		}
	}
}
