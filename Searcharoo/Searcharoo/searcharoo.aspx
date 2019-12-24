<%@ Page Language="c#" autoeventwireup="true" Src="Searcharoo.cs" %>
<%@ import Namespace="System" %>
<%@ import Namespace="System.Xml.Serialization" %>
<%@ import Namespace="System.Collections.Specialized" %>
<%@ import Namespace="Searcharoo.Net" %>
<script runat="server">

    public int wordcount;

    Catalog m_catalog = null;

    /// <summary>Check for catalog<summary>
    public void Page_Load () {

        try {
            // see if there is a catalog object in the cache
            m_catalog = (Catalog)Cache["Searcharoo_Catalog"];
            wordcount = m_catalog.Length; // if so, get the wordcount
        } catch (Exception ex) {
            // otherwise, we'll need to build the catalog
            Response.Write ("Catalog object unavailable : " + ex.ToString() );
            m_catalog = null; // in case
        }
        if (null == m_catalog) {
            Server.Transfer("SearcharooCrawler.aspx");
        }

        if (IsPostBack && (null != m_catalog) ) {
            // Assume Catalog exists in Cache
            string searchterm = searchfor.Text;
            searchterm = searchterm.Trim(' ', '?','\"', ',', '\'', ';', ':', '.', '(', ')').ToLower();

            if (searchterm == String.Empty) {
                Response.Write ("<html><title>No search query</title><body style='font-family:tahoma;font-size:10pt'>");
                Response.Write ("You must type a word to search for<br><a href=searcharoo.aspx>&laquo; back</a><p>");
                Response.End();
            } else {
                Response.Write ("<html><title>Searching for: " + searchfor.Text + "</title>");
                Response.Write ("<body style='font-family:tahoma;font-size:x-small'>");
                Response.Write ("<h2><font color=darkgray>Search</font><font color=red>a</font><font color=blue>r</font><font color=green>o</font><font color=yellow>o</font></h2>");
                Response.Write ("<br><h4>Searching for: " + searchfor.Text + "</h4>");
                Response.Write ("<a href=Searcharoo.aspx>&laquo; new search</a><p>");
                // Do the search
                Hashtable searchResultsArray = m_catalog.Search(searchterm);
                // Format the results
                if (null != searchResultsArray) {
                    // intermediate data-structure for 'ranked' result HTML
                    SortedList output = new SortedList(searchResultsArray.Count); // empty sorted list
                    DictionaryEntry fo;
                    File infile;
                    string result="";
                    // build each result row
                    foreach (object foundInFile in searchResultsArray) {
                        // build the HTML output in the sorted list, so the 'unsorted'
                        // searchResults are 'sorted' as they're added to the SortedList
                        fo = (DictionaryEntry)foundInFile;

                        infile = (File)fo.Key;
                        int rank = (int)fo.Value;
                        // Create the formatted output HTML
                        result = ("<a href=" + infile.Url + ">");
                        result += ("<b>" + infile.Title + "</b></a>");
                        result += (" <a href=" + infile.Url + " target=\"_TOP\" ");
                        result += ("title=\"open in new window\" style=\"font-size:xx-small\">&uarr;</a>");
                        result += (" <font color=gray>("+rank+")</font>");
                        result += ("<br>" + infile.Description + "..." ) ;
                        result += ("<br><font color=green>" + infile.Url + " - " + infile.Size);
                        result += ("bytes</font> <font color=gray>- " + infile.CrawledDate + "</font><p>" ) ;

                        int sortrank = (rank * -1); // multiply by -1 so larger score goes to the top
                        if (output.Contains(sortrank) ) { // rank exists; concatenate same-rank output strings
                            output[sortrank] = ((string)output[sortrank]) + result;
                        } else {
                            output.Add(sortrank, result);
                        }
                        result = ""; // clear string for next loop
                    }
                    // Now output to the HTML Response
                    foreach (object rows in output) { // Already sorted!
                        Response.Write ( (string)((DictionaryEntry)rows).Value );
                    }
                    Response.Write("<p>Matches: " + searchResultsArray.Count);
                } else {
                    Response.Write("<p>Matches: 0");
                }
                Response.Write ("<p><a href=#top>&uarr; top</a>");
                Response.End(); // Stop here
            }
        }
    }

    /// <summary>Perform a search of the catalog</summary>
    public void xxSearch_Click (object sender, System.EventArgs ea) {
        // Assume Catalog exists in Cache
        string searchterm = searchfor.Text;
        searchterm = searchterm.Trim(' ', '?','\"', ',', '\'', ';', ':', '.', '(', ')').ToLower();

        if (searchterm == String.Empty) {
            Response.Write ("<html><title>No search query</title><body style='font-family:tahoma;font-size:10pt'>");
            Response.Write ("You must type a word to search for<br><a href=searcharoo.aspx>&laquo; back</a><p>");
            Response.End();
        } else {
            Response.Write ("<html><title>Searching for: " + searchfor.Text + "</title><body style='font-family:tahoma;font-size:10pt'>");
            Response.Write ("<br><a href=searcharoo.aspx>&laquo; back</a><p>");

            Hashtable searchResultsArray = m_catalog.Search(searchterm);

            SortedList output;
            if (null != searchResultsArray) {
                output = new SortedList(searchResultsArray.Count);
                DictionaryEntry fo;
                File infile;
                string result="";
                foreach (object foundInFile in searchResultsArray) {
                    fo = (DictionaryEntry)foundInFile;

                    infile = (File)fo.Key;
                    int rank = (int)fo.Value;

                    result = ("<a href=" + infile.Url + ">");
                    result += ("<b>" + infile.Title + "</b></a>");
                    result += (" <a href=" + infile.Url + " alt=\"open in new window\">&uarr;</a>");
                    result += (" <font color=gray>("+rank+")</font>");
                    result += ("<br>" + infile.Description + "..." ) ;
                    result += ("<br><font color=green>" + infile.Url + " - " + infile.Size + "bytes</font> <font color=gray>- " + infile.CrawledDate + "</font><p>" ) ;//typeof(obj));

                    int sortrank = (rank * -1);
                    if (output.Contains(sortrank) ) {
                        output[sortrank] = ((string)output[sortrank]) + result;
                    } else {
                        output.Add(sortrank, result);
                    }
                    result = "";
                }

                foreach (object rows in output) {
                    Response.Write ( (string)((DictionaryEntry)rows).Value );
                }

                Response.Write("<p>Matches: " + searchResultsArray.Count);
            } else {
                Response.Write("<p>Matches: 0");
            }
            Response.Write ("<p><a href=#top>&uarr; top</a>");
            Response.End(); //
        }
    } // Search_Click

</script>
<html>
  <head>
    <title>Searcharoo.Net</title>

    <style type="text/css">
    body{margin:0px 0px 0px 0px;font-family:trebuchet ms, verdana, arial, sans-serif;background-color:white;}
    .heading{font-size:xx-large;font-weight:bold;color:darkgrey;filter:DropShadow (Color=#cccccc, OffX=5, OffY=5, Positive=true)}
    .copyright{font-size:xx-small;}
	</style>
</head>
    <body>
        <form runat="server" id="content">
            <center>
            <p class="heading"><font color=darkgray>Search</font><font color=red>a</font><font color=blue>r</font><font color=green>o</font><font color=yellow>o</font></p>

            <table cellspacing="0" cellpadding="4" frame="box" bordercolor="#dcdcdc" rules="none" style="BORDER-COLLAPSE: collapse">
                <tr>
                    <td>
                    <p class="intro">Search for this word (single words only)...<br>
                        <asp:textbox id="searchfor" runat="server" width="300" />
                        <asp:RequiredFieldValidator ControlToValidate="searchfor" runat="server">&larr;</asp:RequiredFieldValidator></p>
                    </td>
                </tr>
                <tr><td align="center"><asp:button runat="server" text="Searcharoo!" class="button" /></td></tr>

                <tr><td><a href="http://www.searcharoo.net/">Searcharoo.Net</a> - <a href="http://www.conceptdevelopment.net/">ConceptDevelopment.Net</a></td></tr>

                <tr><td><p class="copyright">©2004 ConceptDevelopment.Net - Searching <%=wordcount%> words</p></td></tr>
            </table>
            </center>
        </form>
    </body>
</html>