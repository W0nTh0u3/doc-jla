Supported formats:
docx (docm) - Microsoft Office Open XML document format
xlsx (xlsm) - Microsoft Office Open XML spreadsheet format
pptx (pptm) - Microsoft Office Open XML presentation format
csv, txt, utf8 - Text format (can be used for comma separated values - spreadsheet document)

Tag formats:
[[TAG]] [[TAG]:metadata1:metadata2]
{{TAG}} {{TAG}:metadata1:metadata2}
<<TAG>> <<TAG>:metadata1:metadata2>

User manual: https://templater.info/user-manual
Change log: https://templater.info/change-log
License: https://templater.info/eula

Various examples: https://github.com/ngs-doo/TemplaterExamples

Default datatypes (.NET/JVM):
DataSet/NA - special keyword: clone
DataTable/NA - special keyword: fixed
DataRow/NA
IEnumerable/Iterable - special keywords: clone, fixed
IDictionary/Map
object/Object - special keyword: all
IDataReader/ResultSet - special keyword: fixed

Keywords:
clone - used for cloning entire document. Templater will append current document with current content.
fixed - used in resizeable objects (like table) when you don't want to resize that object. For example, you have table with fixed number of rows and want Templater to replace those IEnumerable values and replace all others with empty string
page - used for specifying resizing of the page range in docx. When tag is placed in table and you want to resize entire page, not number of rows in that table, use page to override default context resize
sheet - used for specifying resizing of the sheet in xlsx. If you want to resize sheet range you can place tag in header or use sheet metadata on tag which is used for resizing.
all - replaces all instances of selected tag with provided values. Useful when there is same tag on various places in document and Templater is unable to conclude that they should all be replaced with single value
header - for DataTable/ResultSet/jagged arrays data types, include header during dynamic resize
horizontal-resize - in Excel resize context horizontally instead of vertically
whole-column - use whole column instead of minimum spanning range during horizontal resize
merge-nulls - special handling of null values in tables/cells. Cells will be horizontally merged if null value is detected
span-nulls - special handling of null values in Word tables. Cells will be vertically merged if null value is detected
remove-old-xml - when XElement/Element is provided, remove the XML tree where tag was detected. Useful for cleaning up whitespace garbage
replace-xml - when XElement/Element is provided, remove the children of matching XML tree and replace it with the provided XML. Useful for setting color in Word tables
merge-xml - when XElement/Element is provided, merge provided XML with the surounding XML of the detected tag. Useful for setting color without removing old XML
page-break - when doing resize include page break between elements (probably should not be used)
no-repeat - to invoke old behavior of processing only the first collection with matching tags (probably should not be used)

Default plugin keywords:
format - if encountered on date value it will replace DateTime value with string value (short date string if time part is empty)
format(X) - replaces current value formatted by X argument (for example N2 for number with two decimals)
substring(n) - returns substring of provided values after n chars
substring(n,l) - returns substring of provided values after n chars with l length
padLeft(n) - append space from left to create string of at least n length
padLeft(n,c) - append char c from left to create string of at least n length
padRight(n) - append space from right to create string of at least n length
padRight(n,c) - append char c from right to create string of at least n length
join(X) - flattens array to create a string with X between (for example {1,2,3}.join(-) becomes 1-2-3)
hide - replaces current value with empty string
empty(X) - if value is null or empty (IEnumerable.length = 0) it will replace value with X
bool(yes,no) - boolean value will be converted to yes or no
bool(YES,NO,MAYBE) - boolean value will be converted to YES, NO or MAYBE
offset(D\:H:M) - DateTime value will be offsetted by parsed Timestamp (special sign : is escaped with \)
collapse - if value is null or empty (IEnumerable.length = 0) current context will be collapsed; tag will be removed - resize(tag, 0) will be invoked
collapse-nested - if value is null or empty (IEnumerable.length = 0) context matching all related tags will be collapsed; specified and all nested tags will be removed - resize(tags, 0) will be invoked
collapse-to(otherTag) - if value is null or empty (IEnumerable.length = 0) current context between original and otherTag will be collapsed; tags will be removed - resize(Array(tag, otherTag), 0) will be invoked. Other tag can have same value as original tag

Special datatypes:
Image/Icon/ImageInputStream - convert to image (JVM version uses 96dpi for Image, ImageInputStream preserves DPI and image type)
XElement/Element - insert XML as is into document
IEnumerable<XElement>/Array[Element] - insert XMLs as is into document
DataTable/ResultSet - dynamic resize
Array ([,] or jagged with same dimensions) - dynamic resize
IList<IList<string>>, List<List<string>> (with same dimensions) - dynamic resize
ImageInfo - internal image data type (Java BufferedImage and ImageInputStream and .NET System.Drawing.Image and Icon will be converted into ImageInfo via builtin plugins)

PDF conversion:
Templater doesn't support PDF format, but other tools can be used to convert docx->PDF. Example of LibreOffice usage for PDF conversion:

C:\Program Files (x86)\LibreOffice 4\program\soffice.exe -norestore -nofirststartwizard -nologo -headless -convert-to pdf input-document.docx

will result in input-document.pdf file.
Please note that LibreOffice doesn't support full range of Microsoft Office features and as such have issues with very complicated documents. Best thing to do in that case is to tweak the document template in Word, until LibreOffice can display it like Word.
Docker file for convenient PDF conversion is available at: https://github.com/ngs-doo/TemplaterExamples/tree/master/Advanced/TemplaterServer