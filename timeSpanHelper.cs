if (timestamp < (serverTime + 1000) && (serverTime - timestamp) <= recvWindow)
 {
   // process request
 } 
 else 
 {
   // reject request
 }