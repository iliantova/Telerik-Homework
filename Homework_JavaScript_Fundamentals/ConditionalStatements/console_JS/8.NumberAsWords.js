/*Problem 8. Number as words

Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.*/

function convertNumbers(){
    var number = 1024;
    var result='';
    switch(Math.floor(number/100))
    {
        case 0:if(number==0){result="zero";break;}
        case 1: result+="one hundred ";break;
        case 2: result+="two hundred ";break;
        case 3: result+="three hundred ";break;
        case 4: result+="four hundred ";break;
        case 5: result+="five hundred ";break;
        case 6: result+="six hundred ";break;
        case 7: result+="seven hundred ";break;
        case 8: result+="eight hundred ";break;
        case 9: result+="nine hundred ";break;
        default: break;
    }
    switch(Math.floor(number%100/10))
    {
        case 1:
            if(Math.floor(number%10)==0){result+="ten";break;
            }
            if(Math.floor(number%10)==1){result+=("eleven");break;
            }
            if(Math.floor(number%10)==2){result+=("twelve");break;
            }

            if(Math.floor(number%10)==3){result+=("and thirteen");break;
            }
            if(Math.floor(number%10)==4){result+=("and fourteen");break;
            }
            if(Math.floor(number%10)==5){result+=("and fifteen");break;
            }
            if(Math.floor(number%10)==6){result+=("and sixteen");break;
            }
            if(Math.floor(number%10)==7){result+=("and seventeen");break;
            }
            if(Math.floor(number%10)==8){result+=("and eighteen");break;
            }
            if(Math.floor(number%10)==9){result+=("and nineteen");break;
            }
            break;
        case 2:result+=("twenty ");break;
        case 3:result+=("thirty ");break;
        case 4:result+=("forty ");break;
        case 5:result+=("fifty ");break;
        case 6:result+=("sixty ");break;
        case 7:result+=("seventy ");break;
        case 8:result+=("eighty ");break;
        case 9:result+=("ninty ");break;
        default: break;
    }
    switch (Math.floor(number % 10))
    {
        case 1:
            if (Math.floor(number % 100) / 10 == 1)
            {
                result+=(""); break;
            }
            else
            {
                result+=("one");
            }; break;
        case 2: result+=("two"); break;
        case 3: result+=("three"); break;
        case 4: result+=("four"); break;
        case 5: result+=("five"); break;
        case 6: result+=("six"); break;
        case 7: result+=("seven"); break;
        case 8: result+=("eight"); break;
        case 9: result+=("nine"); break;
    }
    console.log(result);
}
convertNumbers();