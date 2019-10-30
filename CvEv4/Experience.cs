using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CvEv4
{
    class Experience
    {
        // add more stuff to final text (freelance translator etc...)
        Random Rand = new Random();
        public int NumberOfDocs;
        public int NumberOfFields;
        public int NumberOfYears;
        string[] domain = { "Legal", "Financial", "Medical", "Marketing", "Patents" };
        public int Domain
        {
            get
            {
                return domain.Length;
            }
        }
        string[] legDoc = { "contracts", "bylaws", "Directives", "court cases" };
        string[] finDoc = { "annual reports", "balance sheets", "audits"};
        string[] medDoc = { "SPC's", "PIL's", "clinical trials", "MSDS" };
        string[] markDoc = { "Brochures", "Leaflets", "Websites", "campaigns" };
        string[] patDoc = { "Chemical", "Mechanical", "Electronics" };
        int CurrentYear = (int)DateTime.Now.Year;

        public Experience(int numberOfDocs, int numberOfFields, int numberOfYears)
        {
            NumberOfDocs = numberOfDocs;
            NumberOfFields = numberOfFields;
            NumberOfYears = numberOfYears;
        }

        public int DocMaxLength()
        {
            int[] Docs = { legDoc.Length, finDoc.Length, medDoc.Length, markDoc.Length, patDoc.Length };
            int MaxDoc = Docs.Max();
            return MaxDoc;
        }



        public string docRandomizer(string[] docList) //randomizes docs
        {
            int numberOfDocs = NumberOfDocs;
            int i = 0;
            string randomDocList = "";
            if (docList.Length < numberOfDocs)
                numberOfDocs = docList.Length;
            while (i < numberOfDocs) // Limit documents per domain to 3
            {
                i = i + 1;
                string randomDoc = docList[Rand.Next(0, docList.Length)];
                if (randomDocList.Contains(randomDoc))
                    i = i - 1;
                else if (i == 1)
                    randomDocList = randomDocList + " (" + randomDoc;
                else
                    randomDocList = randomDocList + ", " + randomDoc;
            }
            randomDocList = randomDocList + ")";
            return randomDocList;
        }

        public string insDocs(string Domain) // checks domain and inserts paired documents
        {
            Dictionary<string, string[]> CategorizeDocs = new Dictionary<string, string[]>();
            CategorizeDocs.Add(domain[0], legDoc);
            CategorizeDocs.Add(domain[1], finDoc);
            CategorizeDocs.Add(domain[2], medDoc);
            CategorizeDocs.Add(domain[3], markDoc);
            CategorizeDocs.Add(domain[4], patDoc);
            foreach (var entry in CategorizeDocs)
            {
                if (Domain.Contains(entry.Key))
                {
                    Domain = (Domain + docRandomizer(entry.Value));
                }
            }
            return Domain;
        }

        public string selectedDomains(bool [] GetChkdState) //checks which boxes are checked, generates text and combines them
        {
            Dictionary<string, bool> boxesNdocs = new Dictionary<string, bool>();
            boxesNdocs.Add(domain[0], GetChkdState[0]);
            boxesNdocs.Add(domain[1], GetChkdState[1]);
            boxesNdocs.Add(domain[2], GetChkdState[2]);
            boxesNdocs.Add(domain[3], GetChkdState[3]);
            boxesNdocs.Add(domain[4], GetChkdState[4]);
            
            string selectText = "";
            int i = 0;
            foreach (var entry in boxesNdocs)
            {
                if (entry.Value == true)
                {
                    i = i + 1;
                    string checkedText = insDocs(entry.Key);
                    if (i == 1)
                    {
                        selectText = selectText + checkedText;
                    }
                    else if (i < (boxesNdocs.Count + 1))
                    {
                        selectText = selectText + ", " + checkedText;
                    }
                }
            }
            return selectText;
        }

        string randomDomain;
        string domainRandomizer()
        {
            randomDomain = domain[Rand.Next(0, domain.Length)];
            return randomDomain;
        }

        public string randomizedDomains() //generates and combines random text
        {
            int i = 0;
            string randText = "";
            while (i < NumberOfFields)
            {
                i = i + 1;
                string genText = insDocs(domainRandomizer());
                if (randText.Contains(randomDomain))
                    i = i - 1;
                else if (i == 1)
                    randText = randText + genText;
                else
                    randText = randText + ", " + genText;
            }
            return randText;

        }
        public string SelectOrRandomizeDomains(bool IsBoxChecked, bool[] getCheckedState) //Checks if you are going to generate random or selected text
        {
            string finalText = "Freelance translator since " + (CurrentYear - NumberOfYears) + " \r\n\r\n";
            if (IsBoxChecked == true)
                finalText += selectedDomains(getCheckedState);
            else
                finalText += randomizedDomains();
            return finalText;
        }

    }
}
