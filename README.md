# DivTracker

DivTracker is a program designed to show upcoming dividend information for a collection of stocks. The design is simple, consisting of a config button and a fetch button.

<img src="https://i.imgur.com/e1OqiFt.png">


# Setup

The program relies on the IEX Cloud Core Data API to pull the latest information. As such, an account on this service is created. A free account provides more than enough monthly messages for the way I use the program, so as such should be more than enough for most people as well. A paid subscription to their service should work fine though I haven't personally tested it.

First, extract DivTracker to a location of your choice. The program will automatically generate 2 config files, so make sure to place it someplace you have write access to.

Next, create an account at IEX Cloud <a href="https://iexcloud.io/core-data/">here</a>.

After creating your account, you will be brought to the "console" section of there site. There will be a box here with an "API Tokens" label, and a long string of characters beginning with "pk_". Make note of this code, as it will be needed when configuring DivTracker.

Now, open DivTracker and hit the "Config" button, to reach the following configuration screen

<img src="https://i.imgur.com/HN3XjFr.png">

Here, simply input your code from IEX Cloud into the "API Key" field, enter your stock information (symbol and quantity) into the table, and hit save.

Everything is now configured and hitting "Fetch Upcoming Dividends" should retreive all of the information you need.

# Notes

The only prerequesites for this program should be an active IEX Cloud account, and the <a href="https://dotnet.microsoft.com/download/dotnet-framework">dot net framework</a>.

By design, the "Issued dividends in last 6 months" omits stocks that have upcoming dividends announced. As such, you will not see any companies in both the first and second box at the same time. Likewise, the "Non-Dividend" section is simply stocks that haven't issued in the last 6 months. 

As far as libraries go (this is only relevant for those looking to do something  with the source) the program uses RestSharp and Newtonsoft JSON 
