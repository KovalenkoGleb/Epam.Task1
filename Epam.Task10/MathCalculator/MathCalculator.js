'use strict';

function getSumFromString(str) {

    let num = /\-?\d+(\.\d+)?/ig,
      oper = /[^-\d][^\.,\s,а-яёА-ЯЁ1-9,\.,$,=][^-\d]?/ig, 
      allNumbers = str.match(num),
      allOpers = str.match(oper),
      result = +allNumbers.shift(),
      opers = {
        "-": function(a) {
          result = result - a;
        },
        "+": function(a) {
          result = result + a;
        },
        "*": function(a) {
          result = result * a;
        },
        "/": function(a) {
          result = result / a;
        }
      }, i, k, j, n;  
  
    for (i = 0, k = allNumbers.length; i < k; i++) {
  
      if (allOpers[i].length !== 1) {
  
        let arrOfSmthng = allOpers[i].split(" ");
  
        for (j = 0, n = arrOfSmthng.length; j < n; j++) {
  
          if (arrOfSmthng[j].length == 1) {
  
            allOpers[i] = arrOfSmthng[j];
  
          }
  
        }
  
      }
  
      opers[allOpers[i]]( +allNumbers[i] );
    }
  
    return result;
  }