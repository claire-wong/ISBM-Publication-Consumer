# ISBM-Publication-Consumer

This is one of the three-part series of proof-of-concept projects with the primary objective of constructing an interoperable IoT information cluster. The focus is on utilizing non-proprietary Open Industrial Interoperability Ecosystem (OIIE) open standards. Each project within this series explores key facets of building a cohesive and scalable IoT infrastructure, demonstrating the potential of OIIE standards in promoting interoperability in the interconnect world.

![image](/Documents/Images/IoT-Demo.jpg)
Figure 1. The summary of the IoT demo using OIIE standards. Included in this three-part series are ISBM-2.0-Server-Adapter and ISBM-Publication-Provider, hosted in their respective repositories.
A demo Window application that receives and consumes measured data using the ISBM 2.0 Adapter.

### Contents
  
   1. [Objectives](#Objectives)
   2. [Project Information](#Project-Information)
   3. [Before Running the Program](#Before-Running-the-Program)
   4. [Useful Links](#Useful-Links)
   5. [Quick Reference](#Quick-Reference)
  

### Objectives

Build a Windows application to receive published temperature data in CCOM format, embedded in the OAGIS BOD message via an ISBM 2.0 Server adapter from ISBM 2.0 adapter. Making it as an interoperable data consumer.

![image](/Documents/Images/IoT-Demo-Temperature-Gauge.jpg)
Figure 2. This project focuses on the temperature gauge as a sample ISBM Publication Consumer. The temperature data received via the ISBM Server Adapter will be displayed on the temperature gauge.

### Project Information

#### Version v0.2

A Window program written in C#, targeting .Net Framework 4.7.2.

In this project, the NuGet package [RapidRedPanda.ISBM.ClientAdapter](https://www.nuget.org/packages/RapidRedPanda.ISBM.ClientAdapter/#readme-body-tab) is utilized. This package is designed to handle all the details of ISBM implementations for communication with ISBM servers. The ISBM interface will be accessible through object classes that developers should find user-friendly and easy to use. This will cut down the learning curve of building ISBM-compliant devices or applications.

There is also a repository, [ISBM-2.0-Client-SDK](https://github.com/claire-wong/ISBM-2.0-Client-SDK), a full development kit for anyone wishing to learn more using the ISBM Client Adapter.

The application will begin with a temperature gauge and a configuration section. Once the configuration information is entered correctly, you can click on the 'Connect' button to open a Subscription Session. Upon successful session initiation, a session ID will be displayed in the Session ID box. Then, click on the 'Read Temp' button to commence receiving BOD messages. Please note that the first message may have a 5-second delay, as the temperature sensor publishes a message every 5 seconds.

You can click on 'Stop' at any time if you want to halt receiving messages. Click on the 'Disconnect' button to close the Subscription Session. It is preferable to close the session before exiting the application.

#### Tools
     1.  Visual Studio 2022 Community
     
#### Dependencies
     1.  .Net Framework 4.7.2
     2.  RapidRedPanda.ISBM.ClientAdapter 2.0.1 @
     3.  NewtonSoft v12.0.3 @
    
     * NuGet Packages

### Before Running the Program


![image](/Documents/Images/Temperature-Gauge.jpg)

Figure 3. Temperature Gauge

1.  Enter your ISBM Server domain address in Host Name.
2.  Enter your Channel ID if your are not using the ISBM Server Adaptor project provided in this OIIE demo.
3.  When using the ISBM Server Adaptor project provided in this OIIE demo, leave User Name and Password blank. In case of connecting to secured ISBM servers, enter the credential information in User Name and Password 
    boxes.

### Useful Links

#### Standard Organizations
   1. [OpenO&M](https://openoandm.org/)
   2. [MIMOSA](https://www.mimosa.org/)
   3. [International Society of Automation](https://www.isa.org/)
   4. [OAGi](https://oagi.org/)

#### Development Tools
   1. [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/)
   2. [RapidRedPanda.ISBM.ClientAdapter](https://www.nuget.org/packages/RapidRedPanda.ISBM.ClientAdapter/#readme-body-tab)
   

### Quick Reference

   1. OIIE - [OpenO&M Open Industrial Interoperability Ecosystem](https://www.mimosa.org/open-industrial-interoperability-ecosystem-oiie/)
   2. ISBM - [International Society of Automation ISA-95 Message Service Model](https://openoandm.org/files/standards/ISBM-2.0.pdf)
   3. CCOM - [MIMOSA Common Conceptual Object Model](https://www.mimosa.org/mimosa-ccom/)
   4. BOD - [OAGIS Business Object Document](https://www.oagidocs.org/docs/)
