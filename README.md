# InventoryManagementSystem
This is a system developed for ShopRite super mart.
Assumptions made : 
i. For Admin

ii. For Attendants/Vendors/Counter personnel

iii. For BarCode scan feaure. 
    it was assumed that the necessary data for the barcode scanner to retrieve data from the code was already setup.
    For generating barcode Images I used this SDK provided by OnBarcode.com. For reading those barcodes images or scanning those barcode images OnBarcode.com provide the     BarCodeReader SDK.
    So Barcode can be read from ReadBarcodeFromFile or Read BarcodeFromBitmap
    ReadBarcodeFromFile: This method is very simple method to scan the barcode image which will take the filenpath as argument where barcode image is present and retrive     String[] as data.
    Read BarcodeFromBitmap: This one other method is provided by BarcodeScanner dll which will take Bitmap image as input and returns same String[] as output.

iv. 

Link to YouTube video: 
