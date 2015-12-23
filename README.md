# American Apparel Image Scraper
This is a simple application that downloads all of the available hi-resolution images from American Apparel's wholesale website. Please note that use of this application violates American Apparel's Terms of Service and may be illegal in your country. Run this code at your own risk.

## How to setup the application

Download the source code and open `Program.cs` in your IDE.

Find the line that reads:

```
string baseDirectory = @"C:\Directory\To\Save\Image\Files\";
```

Change `baseDirectory` to the directory you want to save the image files in. Each style will be saved in a subfolder named after the style number (*e.g. 2001, BB201, etc.*)

For unisex styles that have both male and female models wearing the product, the default images feature male models. 
If you want to download the images featuring female models edit the following line of code:

```
var productType = ProductType.Standard;
```

Change the code from `ProductType.Standard` to `ProductType.WomensUnisex` to download the female versions.

## Running the application

The program is extremely simple, and has only one prompt:

```
Enter an American Apparel style number or type 'q' to quit:
```

Simply enter the style number of the product you want to download and hit enter. The program will run and download all available images. When it is complete the prompt will appear again. Keep entering style numbers until you are finished, then type `q` and hit enter.

## This code does not handle failures very well

This application wasn't designed for public use and as a result is quite brittle. There is no exception handling, and there are no unit tests. If you need a more robust solution, contact us and we'll come up with a custom application for your needs.
