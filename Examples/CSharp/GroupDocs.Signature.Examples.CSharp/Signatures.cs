﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupDocs.Signature.Config;
using GroupDocs.Signature.Options;
using GroupDocs.Signature.Handler;
using System.IO;
using GroupDocs.Signature.Handler.Input;
using GroupDocs.Signature.Handler.Output;
using GroupDocs.Signature.Domain;
using System.Drawing;

namespace GroupDocs.Signature.Examples.CSharp
{
    class Signatures
    {
        #region WorkingWithTextSignature

        /// <summary>
        /// Signing a pdf document with text
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignPdfDocumentWithText(string fileName)
        {
            //ExStart:signingandsavingpdfdocumentwithtext
            float size = 100;
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup text signature options 
            var signOptions = new PdfSignTextOptions("coca cola");
            signOptions.Left = 100;
            signOptions.Top = 100;
            //this feature is supported in 16.12.0
            signOptions.VerticalAlignment = Domain.VerticalAlignment.Top;
            signOptions.HorizontalAlignment = Domain.HorizontalAlignment.Center;
            signOptions.Margin = new Domain.Padding { Top = 2, Left = 25 };
            //---------------------------
            signOptions.ForeColor = System.Drawing.Color.Red;
            signOptions.BackgroundColor = System.Drawing.Color.Black;
            signOptions.Font = new Domain.SignatureFont { FontSize = size, FontFamily = "Comic Sans MS" };
            string fileExtension = Path.GetExtension(fileName);
            // save document
            Utilities.SaveFile(fileExtension, fileName, handler, signOptions, null, null);
            //ExEnd:signingandsavingpdfdocumentwithtext
        }

        /// <summary>
        /// Signing a cell document with text
        /// </summary>
        /// <param name="fileName">Name of the input filel</param>
        public static void SignCellDocumentWithText(string fileName)
        {
            //ExStart:signingandsavingcellsdocumentwithtext
            float size = 100;
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup text signature options
            var signOptions = new CellsSignTextOptions("coca cola");
            // text position
            signOptions.RowNumber = 3;
            signOptions.ColumnNumber = 6;
            // text rectangle size
            signOptions.Height = 100;
            signOptions.Width = 100;
            //this feature is supported in 16.12.0
            signOptions.VerticalAlignment = Domain.VerticalAlignment.Top;
            signOptions.HorizontalAlignment = Domain.HorizontalAlignment.Center;
            signOptions.Margin = new Domain.Padding { Top = 2, Left = 25 };
            //----------------------------
            // if you need to sign all sheets set it to true
            signOptions.SignAllPages = false;
            signOptions.ForeColor = System.Drawing.Color.Red;
            signOptions.BackgroundColor = System.Drawing.Color.Black;
            signOptions.BorderColor = System.Drawing.Color.Green;
            signOptions.Font = new Domain.SignatureFont { FontSize = size, FontFamily = "Comic Sans MS" };
            // sign first sheet
            signOptions.SheetNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFile(fileExtension, fileName, handler, signOptions, null, null);
            //ExEnd:signingandsavingcellsdocumentwithtext
        }

        /// <summary>
        /// Signing a slide document with text
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignSlideDocumentWithText(string fileName)
        {
            //ExStart:signingandsavingslidesdocumentwithtext
            SignatureConfig config = Utilities.GetConfigurations();
            float size = 100;
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup text signature options 
            var signOptions = new SlidesSignTextOptions("coca cola");
            signOptions.Left = 10;
            signOptions.Top = 10;
            signOptions.Width = 100;
            signOptions.Height = 100;
            //this feature is supported in 16.12.0
            signOptions.VerticalAlignment = Domain.VerticalAlignment.Top;
            signOptions.HorizontalAlignment = Domain.HorizontalAlignment.Center;
            signOptions.Margin = new Domain.Padding { Top = 2, Left = 25 };
            //----------------------------
            signOptions.ForeColor = System.Drawing.Color.Red;
            signOptions.BackgroundColor = System.Drawing.Color.Black;
            signOptions.BorderColor = System.Drawing.Color.Green;
            signOptions.Font = new Domain.SignatureFont { FontSize = size, FontFamily = "Comic Sans MS" };
            signOptions.DocumentPageNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFile(fileExtension, fileName, handler, signOptions, null, null);
            //ExEnd:signingandsavingslidesdocumentwithtext
        }

        /// <summary>
        /// Signing a word document with text
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignWordDocumentWithText(string fileName)
        {
            //ExStart:signingandsavingworddocumentwithtext
            float size = 5;
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup text signature options
            var signOptions = new WordsSignTextOptions("coca cola");
            signOptions.Left = 10;
            signOptions.Top = 10;
            signOptions.Width = 100;
            signOptions.Height = 100;
            //this feature is supported in 16.12.0
            signOptions.VerticalAlignment = Domain.VerticalAlignment.Top;
            signOptions.HorizontalAlignment = Domain.HorizontalAlignment.Center;
            signOptions.Margin = new Domain.Padding { Top = 2, Left = 25 };
            //----------------------------
            signOptions.ForeColor = System.Drawing.Color.Red;
            signOptions.BackgroundColor = System.Drawing.Color.Black;
            signOptions.BorderColor = System.Drawing.Color.Green;
            signOptions.Font = new Domain.SignatureFont { FontSize = size, FontFamily = "Comic Sans MS" };
            signOptions.DocumentPageNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFile(fileExtension, fileName, handler, signOptions, null, null);
            //ExEnd:signingandsavingworddocumentwithtext
        }

        #endregion

        #region WorkingWithImageSignature

        /// <summary>
        /// Signing a pdf document with image
        /// </summary>
        /// <param name="fileName">Name of the input filed</param>
        public static void SignPdfDocumentWithImage(string fileName)
        {
            //ExStart:signingandsavingpdfdocumentwithimage
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup image signature options
            var signOptions = new PdfSignImageOptions("sign.png");
            // image position
            signOptions.Left = 300;
            signOptions.Top = 200;
            signOptions.Width = 100;
            signOptions.Height = 100;
            signOptions.Margin = new Domain.Padding { Top = 2, Left = 25 };
            signOptions.HorizontalAlignment = Domain.HorizontalAlignment.Left;
            signOptions.DocumentPageNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFile(fileExtension, fileName, handler, null, signOptions, null);
            //ExEnd:signingandsavingpdfdocumentwithimage
        }

        /// <summary>
        /// Signing a cell document with image
        /// </summary>
        /// <param name="fileName">Name of the inut file</param>
        public static void SignCellDocumentWithImage(string fileName)
        {
            //ExStart:signingandsavingcelldocumentwithimage
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup image signature options
            var signOptions = new CellsSignImageOptions("sign.png");
            // image position
            signOptions.RowNumber = 10;
            signOptions.ColumnNumber = 10;
            signOptions.SignAllPages = true;
            signOptions.Margin = new Domain.Padding { Top = 2, Left = 8 };
            signOptions.HorizontalAlignment = Domain.HorizontalAlignment.Center;
            signOptions.DocumentPageNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFile(fileExtension, fileName, handler, null, signOptions, null);
            //ExEnd:signingandsavingcelldocumentwithimage
        }

        /// <summary>
        /// Signing a slide document with image
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignSlideDocumentWithImage(string fileName)
        {
            //ExStart:signingandsavingslidedocumentwithimage
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup image signature options
            var signOptions = new SlidesSignImageOptions("sign.png");
            signOptions.Left = 10;
            signOptions.Top = 10;
            signOptions.Width = 100;
            signOptions.Height = 100;
            signOptions.Margin = new Domain.Padding { Top = 2, Left = 15 };
            signOptions.HorizontalAlignment = Domain.HorizontalAlignment.Center;
            signOptions.DocumentPageNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFile(fileExtension, fileName, handler, null, signOptions, null);
            //ExEnd:signingandsavingslidedocumentwithimage
        }

        /// <summary>
        /// Signing word document with image
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignWordDocumentWithImage(string fileName)
        {
            //ExStart:signingandsavingworddocumentwithimage
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup image signature options
            var signOptions = new WordsSignImageOptions("sign.png");
            signOptions.Left = 10;
            signOptions.Top = 10;
            signOptions.Width = 100;
            signOptions.Height = 100;
            signOptions.Margin = new Domain.Padding { Top = 2, Left = 500 };
            signOptions.HorizontalAlignment = Domain.HorizontalAlignment.Right;
            signOptions.DocumentPageNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFile(fileExtension, fileName, handler, null, signOptions, null);
            //ExEnd:signingandsavingworddocumentwithimage
        }

        #endregion

        #region WorkingWithDigitalSignatures

        /// <summary>
        /// Signing a cell document with digital certificate
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignCellDocumentDigitally(string fileName)
        {
            //ExStart:signingcelldocumentwithdigitalcertificate
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup digital signature options
            var signOptions = new CellsSignDigitalOptions("ali.pfx");
            signOptions.Password = "";
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFile(fileExtension, fileName, handler, null, null, signOptions);
            //ExEnd:signingcelldocumentwithdigitalcertificate
        }

        /// <summary>
        /// Signing a pdf document with digital certificate
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignPdfDocumentDigitally(string fileName)
        {
            //ExStart:signingpdfdocumentwithdigitalcertificate
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup digital signature options
            var signOptions = new PdfSignDigitalOptions("acer.pfx", "sign.png");
            signOptions.Password = null;
            // image position
            signOptions.Left = 100;
            signOptions.Top = 100;
            signOptions.Width = 100;
            signOptions.Height = 100;
            signOptions.Visible = true;
            signOptions.SignAllPages = true;
            signOptions.HorizontalAlignment = Domain.HorizontalAlignment.Center;
            signOptions.VerticalAlignment = Domain.VerticalAlignment.Top;
            signOptions.DocumentPageNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFile(fileExtension, fileName, handler, null, null, signOptions);
            //ExEnd:signingpdfdocumentwithdigitalcertificate
        }

        /// <summary>
        /// Signing a word document with digital certificate
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignWordDocumentDigitally(string fileName)
        {
            //ExStart:signingworddocumentwithdigitalcertificate
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup digital signature options
            var signOptions = new WordsSignDigitalOptions("ali.pfx");
            signOptions.Password = "";
            signOptions.Left = 10;
            signOptions.Top = 10;
            signOptions.Width = 100;
            signOptions.Height = 100;
            signOptions.DocumentPageNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFile(fileExtension, fileName, handler, null, null, signOptions);
            //ExEnd:signingworddocumentwithdigitalcertificate
        }

        /// <summary>
        /// Signing a slide document with digital certificate
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignSlideDocumentDigitally(string fileName)
        {
            //ExStart:signingslidedocumentwithdigitalcertificate
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup digital signature options
            var signOptions = new SlidesSignDigitalOptions("ali.pfx");
            signOptions.Password = "";
            signOptions.Left = 10;
            signOptions.Top = 10;
            signOptions.Width = 100;
            signOptions.Height = 100;
            signOptions.DocumentPageNumber = 2;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFile(fileExtension, fileName, handler, null, null, signOptions);
            //ExEnd:signingslidedocumentwithdigitalcertificate
        }

        #endregion

        #region Azure

        /// <summary>
        /// Custom input handling 
        /// </summary>
        /// <param name="inputFileName">Name of the input file</param>
        public static void CustomInputHandler(string inputFileName)
        {
            //ExStart:custominputhandler
            const string DevStorageEmulatorUrl = "http://127.0.0.1:10000/devstoreaccount1/";
            const string DevStorageEmulatorAccountName = "devstoreaccount1";
            const string DevStorageEmulatorAccountKey =
                "Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw==";

            SignatureConfig config = Utilities.GetConfigurations();

            // instantiating the signature handler
            var handler = new SignatureHandler(config);

            SaveOptions saveOptions = new SaveOptions(OutputType.String);
            IInputDataHandler customInputStorageProvider = new AzureInputDataHandler(DevStorageEmulatorUrl,
                DevStorageEmulatorAccountName, DevStorageEmulatorAccountKey, "testbucket");
            SignatureHandler handlerWithCustomStorage = new SignatureHandler(config, customInputStorageProvider);

            // setup image signature options
            var signOptions = new PdfSignImageOptions("sign.png");
            signOptions.DocumentPageNumber = 1;
            signOptions.Top = 500;
            signOptions.Width = 200;
            signOptions.Height = 100;
            string fileExtension = Path.GetExtension(inputFileName);
            Utilities.SaveFile(fileExtension, inputFileName, handler, null, signOptions, null);
            //ExEnd:custominputhandler
        }

        /// <summary>
        /// Custome output handling
        /// </summary>
        /// <param name="inputFileName">Name of the input file</param>
        public static void CustomOutputHandler(string inputFileName)
        {
            //ExStart:customoutputhandler
            const string DevStorageEmulatorUrl = "http://127.0.0.1:10000/devstoreaccount1/";
            const string DevStorageEmulatorAccountName = "devstoreaccount1";
            const string DevStorageEmulatorAccountKey =
                "Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw==";

            SignatureConfig config = Utilities.GetConfigurations();

            // instantiating the signature handler
            var handler = new SignatureHandler(config);

            SaveOptions saveOptions = new SaveOptions(OutputType.String);
            IOutputDataHandler customOutputStorageProvider = new AzureOutputDataHandler(
                DevStorageEmulatorUrl, DevStorageEmulatorAccountName, DevStorageEmulatorAccountKey, "tempbucket");
            SignatureHandler handlerWithCustomStorage = new SignatureHandler(config, customOutputStorageProvider);
            // setup image signature options
            var signOptions = new PdfSignImageOptions("sign.png");
            signOptions.DocumentPageNumber = 1;
            signOptions.Top = 500;
            signOptions.Width = 200;
            signOptions.Height = 100;
            string fileExtension = Path.GetExtension(inputFileName);
            Utilities.SaveFile(fileExtension, inputFileName, handler, null, signOptions, null);
            //ExEnd:customoutputhandler
        }

        #endregion

        #region OpenPasswordProtectedDocuments
        public static void GetPasswordProtectedDocs(string fileName)
        {
            //ExStart:GetPasswordProtectedDocs
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            var signOptions = new WordsSignTextOptions("John Smith");
            // specify load options
            LoadOptions loadOptions = new LoadOptions();
            loadOptions.Password = "1234567890";
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFile(fileExtension, fileName, handler, signOptions, null, null);
            //ExEnd:GetPasswordProtectedDocs
        }
        #endregion

        #region SaveTextSignedOutputWithFormatOptions

        /// <summary>
        /// Signing a pdf document with text
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignPdfDocumentWithTextWithSaveFormat(string fileName)
        {
            //ExStart:signingandsavingpdfdocumentwithtext
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup text signature options 
            var signOptions = new PdfSignTextOptions("coca cola");
            signOptions.Left = 100;
            signOptions.Top = 100;
            string fileExtension = Path.GetExtension(fileName);
            // save document
            Utilities.SaveFileWithFormat(fileExtension, fileName, handler, signOptions, null, null);
            //ExEnd:signingandsavingpdfdocumentwithtext
        }

        /// <summary>
        /// Signing a cell document with text
        /// </summary>
        /// <param name="fileName">Name of the input filel</param>
        public static void SignCellDocumentWithTextWithSaveFormat(string fileName)
        {
            //ExStart:signingandsavingcellsdocumentwithtext
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup text signature options
            var signOptions = new CellsSignTextOptions("coca cola");
            // text position
            signOptions.RowNumber = 3;
            signOptions.ColumnNumber = 6;
            // text rectangle size
            signOptions.Height = 100;
            signOptions.Width = 100;
            // if you need to sign all sheets set it to true
            signOptions.SignAllPages = false;
            // sign first sheet
            signOptions.SheetNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFileWithFormat(fileExtension, fileName, handler, signOptions, null, null);
            //ExEnd:signingandsavingcellsdocumentwithtext
        }

        /// <summary>
        /// Signing a slide document with text
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignSlideDocumentWithTextWithSaveFormat(string fileName)
        {
            //ExStart:signingandsavingslidesdocumentwithtext
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup text signature options 
            var signOptions = new SlidesSignTextOptions("coca cola");
            signOptions.Left = 10;
            signOptions.Top = 10;
            signOptions.Width = 100;
            signOptions.Height = 100;
            signOptions.DocumentPageNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFileWithFormat(fileExtension, fileName, handler, signOptions, null, null);
            //ExEnd:signingandsavingslidesdocumentwithtext
        }

        /// <summary>
        /// Signing a word document with text
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignWordDocumentWithTextWithSaveFormat(string fileName)
        {
            //ExStart:signingandsavingworddocumentwithtext
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup text signature options
            var signOptions = new WordsSignTextOptions("coca cola");
            signOptions.Left = 10;
            signOptions.Top = 10;
            signOptions.Width = 100;
            signOptions.Height = 100;
            signOptions.DocumentPageNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFileWithFormat(fileExtension, fileName, handler, signOptions, null, null);
            //ExEnd:signingandsavingworddocumentwithtext
        }


        #endregion

        #region SaveImageSignedOutputWithFormatOptions

        /// <summary>
        /// Signing a pdf document with image
        /// </summary>
        /// <param name="fileName">Name of the input filed</param>
        public static void SignPdfDocumentWithImageWithSaveFormat(string fileName)
        {
            //ExStart:signingandsavingpdfdocumentwithimageWithSaveFormat
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup image signature options
            var signOptions = new PdfSignImageOptions("sign.png");
            // image position
            signOptions.Left = 300;
            signOptions.Top = 200;
            signOptions.Width = 100;
            signOptions.Height = 100;
            signOptions.DocumentPageNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFileWithFormat(fileExtension, fileName, handler, null, signOptions, null);
            //ExEnd:signingandsavingpdfdocumentwithimageWithSaveFormat
        }

        /// <summary>
        /// Signing a cell document with image
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignCellDocumentWithImageWithSaveFormat(string fileName)
        {
            //ExStart:signingandsavingcelldocumentwithimageWithSaveFormat
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup image signature options
            var signOptions = new CellsSignImageOptions("sign.png");
            // image position
            signOptions.RowNumber = 10;
            signOptions.ColumnNumber = 10;
            signOptions.SignAllPages = true;
            signOptions.DocumentPageNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFileWithFormat(fileExtension, fileName, handler, null, signOptions, null);
            //ExEnd:signingandsavingcelldocumentwithimageWithSaveFormat
        }

        /// <summary>
        /// Signing a slide document with image
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignSlideDocumentWithImageWithSaveFormat(string fileName)
        {
            //ExStart:signingandsavingslidedocumentwithimageWithSaveFormat
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup image signature options
            var signOptions = new SlidesSignImageOptions("sign.png");
            signOptions.Left = 10;
            signOptions.Top = 10;
            signOptions.Width = 100;
            signOptions.Height = 100;
            signOptions.DocumentPageNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFileWithFormat(fileExtension, fileName, handler, null, signOptions, null);
            //ExEnd:signingandsavingslidedocumentwithimageWithSaveFormat
        }

        /// <summary>
        /// Signing word document with image
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignWordDocumentWithImageWithSaveFormat(string fileName)
        {
            //ExStart:signingandsavingworddocumentwithimageWithSaveFormat
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup image signature options
            var signOptions = new WordsSignImageOptions("sign.png");
            signOptions.Left = 10;
            signOptions.Top = 10;
            signOptions.Width = 100;
            signOptions.Height = 100;
            signOptions.DocumentPageNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFileWithFormat(fileExtension, fileName, handler, null, signOptions, null);
            //ExEnd:signingandsavingworddocumentwithimageWithSaveFormat
        }

        #endregion

        #region SaveDigitalSignedOutputWithFormatOptions

        /// <summary>
        /// Signing a cell document with digital certificate
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignCellDocumentDigitallyWithSaveFormat(string fileName)
        {
            //ExStart:signingcelldocumentwithdigitalcertificateWithSaveFormat
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup digital signature options
            var signOptions = new CellsSignDigitalOptions("ali.pfx");
            signOptions.Password = "";
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFileWithFormat(fileExtension, fileName, handler, null, null, signOptions);
            //ExEnd:signingcelldocumentwithdigitalcertificateWithSaveFormat
        }

        /// <summary>
        /// Signing a pdf document with digital certificate
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignPdfDocumentDigitallyWithSaveFormat(string fileName)
        {
            //ExStart:signingpdfdocumentwithdigitalcertificateWithSaveFormat
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup digital signature options
            var signOptions = new PdfSignDigitalOptions("acer.pfx", "sign.png");
            signOptions.Password = null;
            // image position
            signOptions.Left = 100;
            signOptions.Top = 100;
            signOptions.Width = 100;
            signOptions.Height = 100;
            signOptions.DocumentPageNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFileWithFormat(fileExtension, fileName, handler, null, null, signOptions);
            //ExEnd:signingpdfdocumentwithdigitalcertificateWithSaveFormat
        }

        /// <summary>
        /// Signing a word document with digital certificate
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignWordDocumentDigitallyWithSaveFormat(string fileName)
        {
            //ExStart:signingworddocumentwithdigitalcertificateWithSaveFormat
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup digital signature options
            var signOptions = new WordsSignDigitalOptions("ali.pfx");
            signOptions.Password = "";
            signOptions.Left = 10;
            signOptions.Top = 10;
            signOptions.Width = 100;
            signOptions.Height = 100;
            signOptions.DocumentPageNumber = 1;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFileWithFormat(fileExtension, fileName, handler, null, null, signOptions);
            //ExEnd:signingworddocumentwithdigitalcertificateWithSaveFormat
        }

        /// <summary>
        /// Signing a slide document with digital certificate
        /// </summary>
        /// <param name="fileName">Name of the input file</param>
        public static void SignSlideDocumentDigitallyWithSaveFormat(string fileName)
        {
            //ExStart:signingslidedocumentwithdigitalcertificateWithSaveFormat
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // setup digital signature options
            var signOptions = new SlidesSignDigitalOptions("ali.pfx");
            signOptions.Password = "";
            signOptions.Left = 10;
            signOptions.Top = 10;
            signOptions.Width = 100;
            signOptions.Height = 100;
            signOptions.DocumentPageNumber = 2;
            string fileExtension = Path.GetExtension(fileName);
            Utilities.SaveFileWithFormat(fileExtension, fileName, handler, null, null, signOptions);
            //ExEnd:signingslidedocumentwithdigitalcertificateWithSaveFormat
        }

        #endregion

        #region SetupMultipleSignatureOptions
        //Multiple sign options Pdf documents 
        public static void MultiplePdfSignOptoins()
        {
            //ExStart:multiplepdfsignoptions
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // define Signature Options Collection
            var collection = new SignatureOptionsCollection();
            // specify text option
            var signTextOptions = new PdfSignTextOptions("Mr. John", 100, 100, 100, 100);
            // add to collection
            collection.Add(signTextOptions);
            // specify image options
            var signImageOptions = new PdfSignImageOptions("sign.png");
            signImageOptions.Left = 200;
            signImageOptions.Top = 200;
            signImageOptions.Width = 100;
            signImageOptions.Height = 100;
            // add to collection
            collection.Add(signImageOptions);
            // specify digital options
            var signDigitalOptions = new PdfSignDigitalOptions("acer.pfx");
            signDigitalOptions.Password = "1234567890";
            signDigitalOptions.VerticalAlignment = VerticalAlignment.Bottom;
            signDigitalOptions.HorizontalAlignment = HorizontalAlignment.Center;
            // add to collection
            collection.Add(signDigitalOptions);
            // sign document
            var signedPath = handler.Sign<string>("test.pdf", collection, new SaveOptions { OutputType = OutputType.String });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:multiplepdfsignoptions
        }

        //Multiple sign options Cells
        public static void MultipleCellSignOptoins()
        {
            //ExStart:MultipleCellSignOptoins
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // define Signature Options Collection
            var collection = new SignatureOptionsCollection();
            // specify text option
            var signTextOptions = new CellsSignTextOptions("some person");
            // add to collection
            collection.Add(signTextOptions);
            // specify image options
            var signImageOptions = new CellsSignImageOptions("sign.png");
            signImageOptions.Left = 200;
            signImageOptions.Top = 200;
            signImageOptions.Width = 100;
            signImageOptions.Height = 100;
            // add to collection
            collection.Add(signImageOptions);
            // specify digital options
            var signDigitalOptions = new CellsSignDigitalOptions("acer.pfx");
            signDigitalOptions.Password = "1234567890";
            signDigitalOptions.VerticalAlignment = VerticalAlignment.Bottom;
            signDigitalOptions.HorizontalAlignment = HorizontalAlignment.Center;
            // add to collection
            collection.Add(signDigitalOptions);
            // sign document
            var signedPath = handler.Sign<string>("test.xlsx", collection, new SaveOptions { OutputType = OutputType.String });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:MultipleCellSignOptoins
        }
        //Multiple sign options Word
        public static void MultipleWordSignOptoins()
        {
            //ExStart:MultipleWordSignOptoins
            SignatureConfig config = Utilities.GetConfigurations();
            // instantiating the signature handler
            var handler = new SignatureHandler(config);
            // define Signature Options Collection
            var collection = new SignatureOptionsCollection();
            // specify text option
            var signTextOptions = new WordsSignTextOptions("some person");
            // add to collection
            collection.Add(signTextOptions);
            // specify image options
            var signImageOptions = new WordsSignImageOptions("sign.png");
            signImageOptions.Left = 200;
            signImageOptions.Top = 200;
            signImageOptions.Width = 100;
            signImageOptions.Height = 100;
            // add to collection
            collection.Add(signImageOptions);
            // specify digital options
            var signDigitalOptions = new WordsSignDigitalOptions("acer.pfx");
            signDigitalOptions.Password = "1234567890";
            signDigitalOptions.VerticalAlignment = VerticalAlignment.Bottom;
            signDigitalOptions.HorizontalAlignment = HorizontalAlignment.Center;
            // add to collection
            collection.Add(signDigitalOptions);
            // sign document
            var signedPath = handler.Sign<string>("test.docx", collection, new SaveOptions { OutputType = OutputType.String });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:MultipleWordSignOptoins
        }

        //Multiple sign options slides
        //public static void MultipleSlideSignOptoins()
        //{
        //    //ExStart:multipleslidesignoptions
        //    SignatureConfig config = Utilities.GetConfigurations();
        //    // instantiating the signature handler
        //    var handler = new SignatureHandler(config);
        //    // define Signature Options Collection
        //    var collection = new SignatureOptionsCollection();
        //    // specify text option
        //    var signTextOptions = new SlideSignTextOptions("Mr. John", 100, 100, 100, 100);
        //    // add to collection
        //    collection.Add(signTextOptions);
        //    // specify image options
        //    var signImageOptions = new SlideSignImageOptions("sign.png");
        //    signImageOptions.Left = 200;
        //    signImageOptions.Top = 200;
        //    signImageOptions.Width = 100;
        //    signImageOptions.Height = 100;
        //    // add to collection
        //    collection.Add(signImageOptions);
        //    // specify digital options
        //    var signDigitalOptions = new SlideSignDigitalOptions("acer.pfx");
        //    signDigitalOptions.Password = "1234567890";
        //    signDigitalOptions.VerticalAlignment = VerticalAlignment.Bottom;
        //    signDigitalOptions.HorizontalAlignment = HorizontalAlignment.Center;
        //    // add to collection
        //    collection.Add(signDigitalOptions);
        //    // sign document
        //    var signedPath = handler.Sign<string>("butterfly effect.pptx", collection, new SaveOptions { OutputType = OutputType.String });
        //    Console.WriteLine("Signed file path is: " + signedPath);
        //    //ExEnd:multipleslidesignoptions
        //}
        #endregion

        #region SignatureAppearanceOptions

        /// <summary>
        /// Signs Pdf document with Text Signature as Image
        /// This feature is supported in GroupDocs.Signature for .NET 17.01.0 version or greater
        /// </summary>
        public static void SignPdfDocWithTextSignAsImage()
        {
            //ExStart:SignPdfDocWithTextSignAsImage
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup image signature options with relative path - image file stores in config.ImagesPath folder
            PdfSignTextOptions signOptions = new PdfSignTextOptions("John Smith");
            // setup colors settings
            signOptions.BackgroundColor = System.Drawing.Color.Beige;
            // setup text color
            signOptions.ForeColor = System.Drawing.Color.Red;
            // setup Font options
            signOptions.Font.Bold = true;
            signOptions.Font.Italic = true;
            signOptions.Font.Underline = true;
            signOptions.Font.FontFamily = "Arial";
            signOptions.Font.FontSize = 15;
            //type of implementation
            signOptions.SignatureImplementation = PdfTextSignatureImplementation.Image;
            // sign document
            string signedPath = handler.Sign<string>("text.pdf", signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Pdf_TextSignatureAsImage" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:SignPdfDocWithTextSignAsImage
        }

        /// <summary>
        /// Signs Pdf document with Text Signature as Annotation
        /// This feature is supported in GroupDocs.Signature for .NET 17.01.0 version or greater
        /// </summary>
        public static void SignPdfDocWithTextSignAsAnnotation()
        {
            //ExStart:SignPdfDocWithTextSignAsAnnotation
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup image signature options with relative path - image file stores in config.ImagesPath folder
            PdfSignTextOptions signOptions = new PdfSignTextOptions("John Smith");
            signOptions.Left = 100;
            signOptions.Top = 100;
            signOptions.Height = 200;
            signOptions.Width = 200;
            // setup colors settings
            signOptions.BackgroundColor = System.Drawing.Color.Beige;
            // setup text color
            signOptions.ForeColor = System.Drawing.Color.Red;
            // setup Font options
            signOptions.Font.Bold = true;
            signOptions.Font.Italic = true;
            signOptions.Font.Underline = true;
            signOptions.Font.FontFamily = "Arial";
            signOptions.Font.FontSize = 15;
            //type of implementation
            signOptions.SignatureImplementation = PdfTextSignatureImplementation.Annotation;
            // specify extended appearance options
            PdfTextAnnotationAppearance appearance = new PdfTextAnnotationAppearance();
            appearance.BorderColor = Color.Blue;
            appearance.BorderEffect = PdfTextAnnotationBorderEffect.Cloudy;
            appearance.BorderEffectIntensity = 2;
            appearance.BorderStyle = PdfTextAnnotationBorderStyle.Dashed;
            appearance.HCornerRadius = 10;
            appearance.BorderWidth = 5;
            appearance.Contents = signOptions.Text + " content description";
            appearance.Subject = "Appearance Subject";
            appearance.Title = "MrJohn Signature";
            signOptions.Appearance = appearance;
            // sign document
            string signedPath = handler.Sign<string>("text.pdf", signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Pdf_TextSignatureAsAnnotation" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:SignPdfDocWithTextSignAsAnnotation
        }

        /// <summary>
        /// Signs Pdf document with Text Signature as Sticker
        /// This feature is supported in GroupDocs.Signature for .NET 17.02.0 version or greater
        /// </summary>
        public static void SignPdfDocWithTextSignatureAsSticker()
        {
            //ExStart:SignPdfDocWithTextSignatureAsSticker
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup signature options
            PdfSignTextOptions signOptions = new PdfSignTextOptions("John Smith");
            signOptions.Left = 10;
            signOptions.Top = 10;
            signOptions.HorizontalAlignment = HorizontalAlignment.Right;
            signOptions.VerticalAlignment = VerticalAlignment.Bottom;
            signOptions.Margin = new Padding(10);
            signOptions.BackgroundColor = Color.Red;
            signOptions.Opacity = 0.5;
            //type of implementation
            signOptions.SignatureImplementation = PdfTextSignatureImplementation.Sticker;
            // an appearance customizes more specific options
            PdfTextStickerAppearance appearance = new PdfTextStickerAppearance();
            signOptions.Appearance = appearance;
            // text content of an sticker
            appearance.Title = "Title";
            appearance.Subject = "Subject";
            appearance.Contents = "Contents";
            // is sticker opened by default
            appearance.Opened = false;
            // an icon of a sticker on a page
            appearance.Icon = PdfTextStickerIcon.Star;
            //If custom appearance is not set there will be used DefaultAppearance
            //User can change any parameter of DefaultAppearance
            //PdfTextStickerAppearance.DefaultAppearance.Title = "Title";
            //PdfTextStickerAppearance.DefaultAppearance.Subject = "Subject";
            //PdfTextStickerAppearance.DefaultAppearance.Contents = "Contents";
            //PdfTextStickerAppearance.DefaultAppearance.Opened = false;
            //PdfTextStickerAppearance.DefaultAppearance.State = PdfTextStickerState.Completed;
            //PdfTextStickerAppearance.DefaultAppearance.Icon = PdfTextStickerIcon.Note;
            // sign document
            string signedPath = handler.Sign<string>("text.pdf", signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Pdf_TextSignatureAsSticker" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:SignPdfDocWithTextSignatureAsSticker
        }

        /// <summary>
        /// Adds Rotation to Text Signature appearance
        /// This feature is supported in GroupDocs.Signature for .NET 17.02.0 version or greater
        /// </summary>
        public static void AddRotationToTextSignatureAppearance()
        {
            //ExStart:AddRotationToTextSignatureAppearance
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup appearance options
            PdfSignTextOptions signOptions = new PdfSignTextOptions("John Smith");
            signOptions.Font.FontSize = 32;
            signOptions.BackgroundColor = Color.BlueViolet;
            signOptions.ForeColor = Color.Orange;
            signOptions.Left = 200;
            signOptions.Top = 200;
            // setup rotation
            signOptions.RotationAngle = 48;
            // sign document
            string signedPath = handler.Sign<string>("text.pdf", signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Pdf_Text_Rotation" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:AddRotationToTextSignatureAppearance
        }

        /// <summary>
        /// Adds Transparency and Rotation to Text Signature appearance for Slides
        /// This feature is supported in GroupDocs.Signature for .NET 17.02.0 version or greater
        /// </summary>
        public static void AddTransparencyRotationToTextSignatureForSlides()
        {
            //ExStart:AddTransparencyRotationToTextSignatureForSlides
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup appearance options
            SlidesSignTextOptions signOptions = new SlidesSignTextOptions("John Smith");
            signOptions.Left = 100;
            signOptions.Top = 100;
            signOptions.Width = 200;
            signOptions.Height = 200;
            signOptions.ForeColor = Color.Orange;
            signOptions.BackgroundColor = Color.BlueViolet;
            signOptions.BorderColor = Color.Orange;
            signOptions.BorderWeight = 5;
            // setup rotation
            signOptions.RotationAngle = 48;
            // setup transparency
            signOptions.BackgroundTransparency = 0.4;
            signOptions.BorderTransparency = 0.8;
            // sign document
            string signedPath = handler.Sign<string>("butterfly effect.pptx", signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Slides_Text_Transparency_Rotation" });
            Console.WriteLine("Signed file path is: " + signedPath);
                //ExEnd: AddTransparencyRotationToTextSignatureForSlides
        }

        /// <summary>
        /// Adds Rotation to Image Signature appearance
        /// This feature is supported in GroupDocs.Signature for .NET 17.02.0 version or greater
        /// </summary>
        public static void AddRotationToImageSignatureAppearance() {
            //ExStart:AddRotationToImageSignatureAppearance
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            //setup size and position
            PdfSignImageOptions signOptions = new PdfSignImageOptions("signature.jpg");
            signOptions.Left = 100;
            signOptions.Top = 100;
            signOptions.Width = 200;
            signOptions.Height = 200;
            // setup rotation
            signOptions.RotationAngle = 48;
            // sign document
            string signedPath = handler.Sign<string>("text.pdf", signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Pdf_Image_Rotation" });
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:AddRotationToImageSignatureAppearance
        }
        #endregion
        #region SetVerificationOptions

        /// <summary>
        /// Verifies PDF Documents signed with Text Signature 
        /// This feature is supported in GroupDocs.Signature for .NET 17.01.0 version or greater
        /// </summary>
        public static void TextVerificationOfPdfDocument()
        {
            //ExStart:TextVerificationOfPdfDocument
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            String text = "John Smith, esquire";
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup image signature options with relative path - image file stores in config.ImagesPath folder
            PdfSignTextOptions signOptions = new PdfSignTextOptions(text);
            signOptions.Left = 100;
            signOptions.Top = 100;
            signOptions.DocumentPageNumber = 1;
            // sign document
            string signedPath = handler.Sign<string>("text.pdf", signOptions,
                new SaveOptions { OutputType = OutputType.String, OutputFileName = "Pdf_Documents_Verification_Text" });
            // setup digital verification options
            PDFVerifyTextOptions verifyOptions = new PDFVerifyTextOptions(text);
            verifyOptions.DocumentPageNumber = 1;

            //verify document
            VerificationResult result = handler.Verify(signedPath, verifyOptions);
            Console.WriteLine("Verification result: " + result.IsValid);
            //ExEnd:TextVerificationOfPdfDocument
        }

        /// <summary>
        /// Verifies Cells Documents signed with .cer digital certificates 
        /// This feature is supported in GroupDocs.Signature for .NET 17.01.0 version or greater
        /// </summary>
        public static void DigitalVerificationOfCellsDocWithCerCertificateContainer()
        {
            //ExStart:DigitalVerificationOfCellsDocWithCertificateContainer
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup digital verification options
            CellsVerifyDigitalOptions verifyOptions = new CellsVerifyDigitalOptions("signtest.cer");
            verifyOptions.Comments = "Test1";
            verifyOptions.SignDateTimeFrom = new DateTime(2017, 1, 26, 14, 55, 07);
            verifyOptions.SignDateTimeTo = new DateTime(2017, 1, 26, 14, 55, 09);

            //verify document
            VerificationResult result = handler.Verify("digital signatures.xlsx", verifyOptions);
            Console.WriteLine("Signed file verification result: " + result.IsValid);
            //ExEnd:DigitalVerificationOfCellsDocWithCertificateContainer
        }

        /// <summary>
        /// Digitally verifies cells document with .pfx certificate container
        /// This feature is supported in GroupDocs.Signature for .NET 17.01.0 version or greater
        /// </summary>
        public static void DigitalVerificationOfCellsDocWithPfxCertificateContainer()
        {
            //ExStart:DigitalVerificationOfCellsDocWithPfxCertificateContainer
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup digital verification options
            CellsVerifyDigitalOptions verifyOptions1 = new CellsVerifyDigitalOptions("signtest.pfx");
            //password is needed to open .pfx certificate
            verifyOptions1.Password = "123";
            CellsVerifyDigitalOptions verifyOptions2 = new CellsVerifyDigitalOptions("signtest.cer");
            VerifyOptionsCollection verifyOptionsCollection =
                new VerifyOptionsCollection(new List<VerifyOptions>() { verifyOptions1, verifyOptions2 });

            //verify document
            VerificationResult result = handler.Verify("digital signatures.xlsx", verifyOptionsCollection);
            Console.WriteLine("Signed file verification result: " + result.IsValid);
            //ExEnd:DigitalVerificationOfCellsDocWithPfxCertificateContainer
        }

        /// <summary>
        /// Verifies pdf Documents signed with .cer digital certificates 
        /// This feature is supported in GroupDocs.Signature for .NET 17.01.0 version or greater
        /// </summary>
        public static void DigitalVerificationOfPdfWithCerContainer()
        {
            //ExStart:DigitalVerificationOfPdfWithCertificateContainer
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup digital verification options
            PDFVerifyDigitalOptions verifyOptions = new PDFVerifyDigitalOptions("ali.cer");
            verifyOptions.Reason = "Test reason";
            verifyOptions.Contact = "Test contact";
            verifyOptions.Location = "Test location";
            //verify document
            VerificationResult result = handler.Verify("digital signatures.pdf", verifyOptions);
            Console.WriteLine("Signed file verification result: " + result.IsValid);
            //ExEnd:DigitalVerificationOfPdfWithCertificateContainer
        }


        /// <summary>
        /// Digitally verifies pdf document with .pfx certificate container
        /// This feature is supported in GroupDocs.Signature for .NET 17.01.0 version or greater
        /// </summary>
        public static void DigitalVerificationOfPdfWithPfxCertificateContainer()
        {
            //ExStart:DigitalVerificationOfPdfWithPfxCertificateContainer
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup digital verification options
            PDFVerifyDigitalOptions verifyOptions1 = new PDFVerifyDigitalOptions("ali.pfx");
            //password is needed to open .pfx certificate
            verifyOptions1.Password = "1234567890";
            PDFVerifyDigitalOptions verifyOptions2 = new PDFVerifyDigitalOptions("ali.cer");
            VerifyOptionsCollection verifyOptionsCollection =
                new VerifyOptionsCollection(new List<VerifyOptions>() { verifyOptions1, verifyOptions2 });
            //verify document
            VerificationResult result = handler.Verify("digital signatures.pdf", verifyOptionsCollection);
            Console.WriteLine("Signed file verification result: " + result.IsValid);
            //ExEnd:DigitalVerificationOfPdfWithPfxCertificateContainer
        }

        /// <summary>
        /// Verifies word Documents signed with .cer digital certificates 
        /// </summary>
        public static void DigitalVerificationOfWordDocWithCerCertificateContainer()
        {
            //ExStart:DigitalVerificationOfWordDocWithCertificateContainer
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);

            VerifyOptionsCollection verifyOptionsCollection = new VerifyOptionsCollection();
            // setup digital verification options
            WordsVerifyDigitalOptions verifyOptions = new WordsVerifyDigitalOptions("signtest.cer");
            verifyOptions.Comments = "Test1";
            verifyOptions.SignDateTimeFrom = new DateTime(2017, 1, 26, 14, 55, 57);
            verifyOptions.SignDateTimeTo = new DateTime(2017, 1, 26, 14, 55, 59);
            //verify document
            VerificationResult result = handler.Verify("digital signatures.docx", verifyOptions);
            Console.WriteLine("Signed file verification result: " + result.IsValid);
            //ExEnd:DigitalVerificationOfWordDocWithCertificateContainer
        }


        /// <summary>
        /// Digitally verifies word document with .pfx certificate container
        /// This feature is supported in GroupDocs.Signature for .NET 17.01.0 version or greater
        /// </summary>
        public static void DigitalVerificationOfWordDocWithPfxCertificateContainer()
        {
            //ExStart:DigitalVerificationOfWordDocWithPfxCertificateContainer
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup digital verification options
            WordsVerifyDigitalOptions verifyOptions1 = new WordsVerifyDigitalOptions("signtest.pfx");
            //password is needed to open .pfx certificate
            verifyOptions1.Password = "123";
            WordsVerifyDigitalOptions verifyOptions2 = new WordsVerifyDigitalOptions("signtest.cer");
            VerifyOptionsCollection verifyOptionsCollection =
                new VerifyOptionsCollection(new List<VerifyOptions>() { verifyOptions1, verifyOptions2 });
            //verify document
            VerificationResult result = handler.Verify("digital signatures.docx", verifyOptionsCollection);
            Console.WriteLine("Signed file verification result: " + result.IsValid);
            //ExEnd:DigitalVerificationOfWordDocWithPfxCertificateContainer
        }

        /// <summary>
        /// Verifies PDF Document signed with Text Signature Sticker
        /// This feature is supported in GroupDocs.Signature for .NET 17.02.0 version or greater
        /// </summary>
        public static void VerifyPdfDocumentSignedWithTextSignatureSticker()
        {
            //ExStart:VerifyPdfDocumentSignedWithTextSignatureSticker
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup verification options
            PDFVerifyTextOptions verifyOptions = new PDFVerifyTextOptions();
            // specify verification type
            verifyOptions.SignatureImplementation = PdfTextSignatureImplementation.Sticker;
            // verify only page with specified number
            verifyOptions.DocumentPageNumber = 1;
            // verify all pages of a document if true
            verifyOptions.VerifyAllPages = true;
            //If verify option Text is set, it will be searched in Title, Subject and Contents
            verifyOptions.Text = "Contents";
            // create Verify Extensions
            PdfTextStickerVerifyExtensions extensions = new PdfTextStickerVerifyExtensions();
            //If verify option is set, then appropriate property of Sticker must be equals
            extensions.Contents = "Contents";
            extensions.Subject = "Subject";
            extensions.Title = "Title";
            extensions.Icon = PdfTextStickerIcon.Cross;
            // set extensions to verification options
            verifyOptions.Extensions = extensions;
            //verify document
            VerificationResult result = handler.Verify("test_text_sticker.pdf", verifyOptions);
            Console.WriteLine("Verification result is: " + result.IsValid);
            //ExEnd:VerifyPdfDocumentSignedWithTextSignatureSticker
        }

        /// <summary>
        /// Verifies PDF Document signed with Text Signature Annotation
        /// This feature is supported in GroupDocs.Signature for .NET 17.02.0 version or greater
        /// </summary>
        public static void VerifyPdfDocumentSignedWithTextSignatureAnnotation()
        {
            //ExStart:VerifyPdfDocumentSignedWithTextSignatureAnnotation
            // setup Signature configuration
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup verification options
            PDFVerifyTextOptions verifyOptions = new PDFVerifyTextOptions();
            // specify verification type
            verifyOptions.SignatureImplementation = PdfTextSignatureImplementation.Annotation;
            // verify only page with specified number
            verifyOptions.DocumentPageNumber = 1;
            // verify all pages of a document if true
            verifyOptions.VerifyAllPages = true;
            //If verify option Text is set, it will be searched in Title, Subject and Contents
            verifyOptions.Text = "John Smith_1";
            // create Verify Extensions
            PdfTextAnnotationVerifyExtensions extensions = new PdfTextAnnotationVerifyExtensions();
            //If verify option is set, then appropriate property of Annotation must be equals
            extensions.Contents = "John Smith_1";
            extensions.Subject = "John Smith_2";
            extensions.Title = "John Smith_3";
            // set extensions to verification options
            verifyOptions.Extensions = extensions;
            //verify document
            VerificationResult result = handler.Verify("test_text_annotation.pdf", verifyOptions);
            Console.WriteLine("Verification result is: " + result.IsValid);
            //ExEnd:VerifyPdfDocumentSignedWithTextSignatureAnnotation
        }

        #endregion

        /// <summary>
        /// OUtput file name can be set in saveoptions
        /// </summary>
        public static void SetOutputFileName()
        {
            //ExStart:SetOutputFileName
            SignatureConfig signConfig = Utilities.GetConfigurations();
            // instantiating the conversion handler
            SignatureHandler handler = new SignatureHandler(signConfig);
            // setup options with text of signature
            SignOptions signOptions = new CellsSignTextOptions("John Smith");
            // specify load options
            LoadOptions loadOptions = new LoadOptions();
            // specify save options
            CellsSaveOptions saveOptions = new CellsSaveOptions()
            { OutputType = OutputType.String, OutputFileName = "FileWithDifferentFileName" };
            // sign document
            string signedPath = handler.Sign<string>("pie chart.xlsx", signOptions, loadOptions, saveOptions);
            Console.WriteLine("Signed file path is: " + signedPath);
            //ExEnd:SetOutputFileName
        }


    }
}
