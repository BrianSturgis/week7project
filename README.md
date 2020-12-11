

<div align="center">
<img src="https://github.com/BrianSturgis.png" width="200px" height="auto" >
</div>
<p align="center"> Authored by Brian Sturgis</p>
<p align="center">Updated on Dec 7th, 2020</p>


## Detailed Description


## KNOWN BUGS
nd have not been hidden for use with UI artwork to come.


## Setup/Installation Requirements

## GIT HUB
- repository location (https://github.com/BrianSturgis/week6project
- open through a git termianl or clone editor.
- got to repo location.
- using git commands clone to local repo or click "download" and unpack on machine


## USING THIS APPLICATION
his app uses node.js. If you do not already have node.js installed, visit https://nodejs.org/en/download/ and install.
After installing node, navigate to the root directory of the cloned repo and type in "npm install".
Then type in "npm run build".

If you would like to run the program through the server, you can type "npm run start" which will build the program and launch the preview to the local server.

If you use Jest to run your tests, open your terminal and go to the root of the project directory and type in "npm test".
If you would like to run the program through the server, you can type "npm run start" which will build the program and launch the preview to the local server.





## Completing Application Setup
Once you have gotten a 200 code response (i.e. a successful response) in Postman, copy the API key and add it as a variable to the first line of your .env file in this format API_KEY={your-api-key-here}. As mentioned before, doing so will keep your personal data (the API key) private.  This is very important as commiting the project with an api key will store that api key in the commit history and can be pushed to github.
Once complete the API key you acquired in the 'API Key and Using an .env File' section above will automatically apply to the currency exchange API link, and the application should run as expected.  .env files are great in cojunction with .gitignore file to keep things private.

## API ERROR CODES
- "unsupported-code" if we don't support the supplied currency code (see supported currencies...).
- "base-code-only-on-pro" if a request to the free.exchangerate-api.com endpoint is for a base code other than USD or EUR.
- "malformed-request" when some part of your request doesn't follow the structure shown above.
- "invalid-key" when your API key is not valid.
- "quota-reached" when your account has reached the the number of requests allowed by your plan.
- "not-available-on-plan" if your plan level doesn't support this type of request.

## Stretch goals


## Support and contact details
email Brian Sturgis @ <sturujisu@gmail.com>


## TESTS

| CurrencyConverter(); |  |
| ------| -----------|
| test: will make the API call  |                         |
|  
| expect:  | (response).toEqual(200k). |



| getRateUSA(); |  |
| ------| -----------|
| test:   | will recieve {response.conversion_rates.USA} |
| 
| expect:  | (usa 1) .toEqual(usa 1) |


## Technologies Used
* HTML
* CSS
* Bootstrap
* Javascript
* jQuery
* Coffee
* jest
* Babel
* lint
* webpack
  


### License

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE..



Copyright (c) 2020 **Brian Micheal Sturgis**
