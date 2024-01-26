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

The program starts with an Open Publication Session, proceeds to measure temperature, and posts the publication every five seconds. Users can stop the temperature acquisition and publication loop at their discretion. Additionally, the program provides an option to Close the Publication Session before exiting.

#### Tools
     1.  Visual Studio 2022 Community
     
#### Dependencies
     1.  .Net Framework 4.7.2
     2.  RapidRedPanda.ISBM.ClientAdapter 2.0.1 @
     3.  NewtonSoft v12.0.3 @
    
     * NuGet Packages

### Before Running the Program


![image](/Documents/Images/Temperature-Gauge.png)

Figure 3. Temperature Gauge

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
