using binanceProject;


General API Information
Some endpoints will require an API Key.
The base endpoint is: https://www.trbinance.com
Some specified APIs another base endpoint is: https://api.binance.me
All endpoints return a JSON object.
Data is returned in ascending order. Oldest first, newest last.
All time and timestamp related fields are in milliseconds.
HTTP Return Codes
HTTP 4XX return codes are used for malformed requests; the issue is on the sender's side.

HTTP 403 return code is used when the WAF Limit (Web Application Firewall) has been violated.

HTTP 429 return code is used when breaking a request rate limit.

HTTP 418 return code is used when an IP has been auto-banned for continuing to send requests after receiving 429 codes.

HTTP 5XX return codes are used for internal errors; the issue is on Server's side. It is important to NOT treat this as a failure operation; the execution status is UNKNOWN and could have been a success.

Response fields description
Name	Type	Mandatory	Description
code	Number	Yes	Error Code，0 is success，else is fail
msg	String	Yes	error message
timestamp	Number	Yes	server timestamp
data	Object	No	response data
General Information on Endpoints
For GET endpoints, parameters must be sent as a query string.
For POST endpoints, the parameters may be sent as a query string or in the request body with content type application/x-www-form-urlencoded. You may mix parameters between both the query string and request body if you wish to do so.
Parameters may be sent in any order.
If a parameter sent in both the query string and request body, the body string parameter will be used.