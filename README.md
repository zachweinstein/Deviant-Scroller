# Deviant-Scroller

DeviantArt lacks a 'random' button. This Visual C# program allows the user to randomly select deviations from a user's gallery.

## Setup

1. Create a DeviantArt application

    * Go to <https://www.deviantart.com/developers/apps> (log in or create an account if you need to)

    * Click "Register your Application" to create a new application with an arbitrary name.

    * Under "OAuth2 Grant Type (Required)" set box to _**Authorization Code**_.

    * In the box under "OAuth2 Redirect URI Whitelist (Required)" place an arbitrary URI, such as <http://121.0.0.1/>

    Your application settings should look like this:

    ![Application Settings](https://i.imgur.com/8IMFWAJ.png)

    * Save the application, make note of the client_id and client_secret

2. Add the client_id and client_secret to DeviantScroller.cs

    > private string client_id = "CLIENT_ID"; // replace this

    > private string client_secret = "CLIENT_SECRET"; // replace this

The application should now be able to compile