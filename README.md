# CSharp-Interfaces
An introduction to graphic user interfaces (GUIs) in the C# programming language. 

# Requirements
Windows Operating System. The operating system could be hosted on a non-windows computer (for example a Mac running a windows virtual machine could follow along with this tutorial, but a Mac running OSX cannot). Windows 10 is highly recommended, this may be doable with an earlier version of Windows but I cannot gurantee that it will work properly.
Microsoft Account (This is free you would just have to make an account with Microsoft so they can license your copy of Visual Studio)

# Install Visual Studio Community 2019
Visual Studio is an integrated development environment (IDE) produced by Microsoft. Visual Studio can be used for a lot of programming languages, but one of the most popular uses for this IDE is to program in C#. The installation process is not particularly complicated, but it does take some time (depending on internet speeds, and packages installed with the IDE it could take hours). The following information will detail the installation process.

Video Method: If you prefer to watch a video on how to install the IDE, I made a youtube video about a year ago outlining the details of how to properly install the IDE for use with the C# programming language. My youtube video can be found here: https://www.youtube.com/watch?v=3Tcq_k6UQSU

Text Method: To download Visual Studio Community 2019, visit https://visualstudio.microsoft.com/downloads/ and click on the download button under the Community edition. The community edition is the free edition of Visual Studio, it has everything an individual developer needs and is 100% free. After the download is complete, double click on the downloaded vs_community.exe file, this will start the Visual Studio Installer program. It is important to note that the installer is an entirely separate program from Visual Studio itself. The installer handles the packages that are installed into the Visual Studio IDE. Under the workloads tab (the furthest tab to the left) you should see a section labeled 'Desktop & Mobile' and within this section there is a box with the words '.NET Desktop Development' in bold. Go ahead and check the checkbox corresponding to the '.NET Desktop Development' box. Then click install in the lower right hand corner. Now, grab a cup of coffee and let the installer work its magic. This is the lengthiest part of the installation.

# Create a Project
Start Visual Studio Community 2019 (I usually do this by typing into the Windows search bar 'Visual' and then clicking on the Visual Studio 2019 program listed there, but there is other ways of starting up the program). Next, click on 'Create a New Project' on the right hand side of the Visual Studio window. Now, we have to select a project template. The project template does a lot of the setup work for us so it is very useful to pick the right one depending on what you want to do. In the search bar at the top of the window, type in 'WPF' and then click on the listed entry titled 'WPF Application' then click Next in the lower right hand corner. Now we need to configure our project. We need to specify the project name, you can name your project however you wish, I will be naming my project 'Grocery_List_Generator'. Next we need to specify the locaiton in which the project is saved, this can be anywhere on your computer, it just helps to keep your projects in an accessible location such as in your 'Documents' folder. You can click the 3 dots next to the textbox to open up a Explorer window to make this easier. The last text box is the Solution Name, I always just leave this as is (automatically set to the name of the project). Click next in the lower right hand corner. It will take a second for Visual Studio to generate your project.

# Designing the Graphic User Interface
Navigate to the 'MainWindow.xaml' window, this is the window for all the graphical design. Visual Studio is nice because you can drag and drop elements onto the window. You will notice that there is some code beneath the design window, this code is XAML code. Although, we can do a lot with the drag and drop, we will have to write some code in the XAML to configure some things, more on this later. On the left hand side of the Visual Studio window, you should see a tab called 'Toolbox', click on this tab. This brings up all the drag and drop elements that we can drag onto our design window. I will show you exactly how to create the graphical user interface for this project.

# Event Handlers
Now that we have the graphical design of the project completed, we need to add some functionality. To do this, we need to add event handlers to the elements we just added to the design. The event handlers are the functions that are called when something happens such as a mouse clicks an element. Luckily, Visual Studio does a lot of this for us, all we have to do is specify which event handler we want for a element and then Visual Studio will generate the event code for us in the C# program. 

# Coding the Events
Navigate to the MainWindow.xaml.cs file, this is where our program's C# code is. Each element of our design has a specific purpose and therefore each event has a specific purpose, which means each event needs specific code to make the program work how we want it to. In this program we are just sort of moving data around to different graphical elements which makes it easier to visualize how these event handlers are working. Follow along to see how the C# code interacts with our design code (XAML).

# Saving the List and the Selection List
Obviously we want to be able to save our grocery list so we could use it in the (near) future. Rather than just specifying some file path in our code and always dumping all the contents of the grocery list into that same file, it is better in this case to let the user chose where they want their list to be saved and what the list should be named. We can allow for this functionality by opening up an Explorer window from within our code. We will have to add one reference to our project. To do this go to the 'Solution Explorer' tab on the right side of the window, and then look for 'References' in the list. Right click on 'References' then select 'Add Reference'. Navigate the list of References under the 'Assemblies' tab and look for a reference called 'System.Windows.Forms'. Click the check box next to this reference and then click 'OK' at the bottom of this pop-up window. This reference will handle the Explorer window but we need another namespace to handle the file operations. At the top of the cs file add the following line 'using System.IO', there should be a handful of namespaces already referenced here. We also want to save the selection list so the user does not have to add all the items everytime they open the program. This can be done by writing the logic for the Window_Closed event.

# Conclusion
The only two files that we worked with is the 'MainWindow.xaml' and the 'MainWindow.xaml.cs' files, so you can check out the project code in this github repository. You may also want to consider making a shortcut to this program's .exe file and saving the shortcut on your desktop so you can easily open up this program whenever you want to. Congratulations! You can now make a grocery list entirely from your program. It is nice that we have produced a .txt document as these can easily be shared across different devices. I have done this in the past where I will make my grocery list with this program, save my groceryList.txt file and then send that to myself on discord so I can open it up on my phone when I am at the grocery store. Hope you enjoyed this lesson :)

