# InventoryManagementSystem
This is a system developed for ShopRite super mart.

Link to YouTube video: 

Assumptions made : 
i. For Admin

ii. For Attendants/Vendors/Counter personnel

iii. Dashboard
The dashboard contains a navigation sidebar and a primary panel that displays table content.
Here are the navigation options:
    a. Product: The Product button displays the products in stock in a table. Products have columns such as product id, name, quantity, price, description, and category.        A product can be modified or removed from stock. There is a new button for adding new goods to the stock.
    b. Sales: The sales area includes daily and paste sales. Every purchase made by a client is saved here together with the customer and product information. When a            sale is made, a sales invoice/receipt is created, which may then be sent on to the customer. A sale can also be amended for circumstances that follow the                company's return rules.
    c. Attendants: 
    
    d. Category: 
    
    
iv. For BarCode scan feaure. 
    it was assumed that the necessary data for the barcode scanner to retrieve data from the code was already setup.
    For generating barcode Images I used this SDK provided by OnBarcode.com. For reading those barcodes images or scanning those barcode images OnBarcode.com provide the     BarCodeReader SDK.
    So Barcode can be read from ReadBarcodeFromFile or Read BarcodeFromBitmap
    ReadBarcodeFromFile: This method is very simple method to scan the barcode image which will take the filenpath as argument where barcode image is present and retrive     String[] as data.
    Read BarcodeFromBitmap: This one other method is provided by BarcodeScanner dll which will take Bitmap image as input and returns same String[] as output.



