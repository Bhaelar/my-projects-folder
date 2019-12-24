
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Specialized;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Linq;

namespace search_engine
{
	/// <summary>
	/// Description of methods.
	/// </summary>
	public class methods
	{
		private static List<string> randFiles;
		
		private static List<String> AddFileNamesToList(string sourceDir, List<string> randFiles)
	    {
				
				List<string> allFiles = new List<string>();
	            string[] fileEntries = Directory.GetFiles(sourceDir);
	            foreach (string fileName in fileEntries)
	            {
	                allFiles.Add(fileName);
	            }
	
	            //Recursion    
	            string[] subdirectoryEntries = Directory.GetDirectories(sourceDir);
	            foreach (string item in subdirectoryEntries)
	            {
	                // Avoid "reparse points"
	                if ((File.GetAttributes(item) & FileAttributes.ReparsePoint) != FileAttributes.ReparsePoint)
	                {
	                    AddFileNamesToList(item, allFiles);
	                }
	            }
	
	            return allFiles;
	    }
		
		protected static string stripHtml(string strHtml) {
         //Strips the HTML tags from strHTML
         System.Text.RegularExpressions.Regex objRegExp
                 = new System.Text.RegularExpressions.Regex("<(.|\n)+?>");

         // Replace all tags with a space, otherwise words either side
         // of a tag might be concatenated
         string strOutput = objRegExp.Replace(strHtml, " ");

         // Replace all < and > with &lt; and &gt;
         strOutput = strOutput.Replace("<", "&lt;");
         strOutput = strOutput.Replace(">", "&gt;");

         return strOutput;
    }
		
		// variables used in recursive method CrawlCatalog
         static string fileContents,fileurl, filepath;
         static string[] filepathA;
         static string filetitle="";
         static long   filesize=0;
         static string filedesc="";
         
         /// <summary>Crawl through a directory, processing files matching the pattern</summary>
         private void CrawlCatalog (string path) {
         	foreach(string f in randFiles) {
         		System.IO.StreamReader reader = System.IO.File.OpenText(path + @"\" + f);
         	}
         	fileContents = reader.ReadToEnd();
            reader.Close(); // now use the fileContents to build the catalog..
            // ### Grab the <TITLE> ###
            Match TitleMatch = Regex.Match(fileContents, "<title>([^<]*)</title>", RegexOptions.IgnoreCase | RegexOptions.Multiline );
            filetitle = TitleMatch.Groups[1].Value;
             // ### Parse out META data ###
            Match DescriptionMatch = Regex.Match( fileContents, "<META NAME=\"DESCRIPTION\" CONTENT=\"([^<]*)\">", RegexOptions.IgnoreCase | RegexOptions.Multiline );
            filedesc = DescriptionMatch.Groups[1].Value;
            // ### Get the file SIZE ###
            filesize = fileContents.Length;
            // ### Now remove HTML, convert to array, clean up words and index them ###
            fileContents = stripHtml (fileContents);


            string wordsOnly = stripHtml(fileContents);
            
            Regex r = new Regex(@"\s+");           // remove all whitespace
            wordsOnly = r.Replace(wordsOnly, " "); // compress all whitespace to one space
            string [] wordsOnlyA = wordsOnly.Split(' '); // results in an array of words
            
             // Create the object to represent this file (there will only ever be ONE instance per file)
                 
              File infile = new File (fileurl
                                     , filetitle
                                     , filedesc
                                     , DateTime.Now
                                     , filesize) ;
             Catalog m_catalog = new Catalog();
             
             // ### Loop through words in the file ###
			    int i = 0;     // Position of the word in the file (starts at zero)
			    string key = ""; // the 'word' itself
			    // Now loop through the words and add to the catalog
			    foreach (string word in wordsOnlyA) {
			        key = word.Trim(' ', '?','\"', ',', '\'', ';', ':', '.', '(', ')').ToLower();
			        m_catalog.Add (key, infile, i);
			        i++;
			    } // foreach word in the file
                 Console.WriteLine(" parsed " + i.ToString() + " words<br>");
         }
		
	}
}
