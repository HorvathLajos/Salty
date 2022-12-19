$(document).ready(function(){

    document.title = "SALTy title";
    window.document.title = "A Saltier title";

    document.querySelector("#searchBtn").addEventListener("click", () => {
        myFunctions.searchStuff(document.querySelector("#searchField").value);
    });
    document.querySelector("#searchField").addEventListener("keyup", (e) => {
        if (e.key === 'Enter' || e.keyCode === 13) {
            myFunctions.searchStuff(document.querySelector("#searchField").value);
        }
    });
    
});
myFunctions = {
    searchStuff: (searchPhrase) => {
        var newMain = document.createElement('div');
            newMain.setAttribute("name", "newMain");
        for (let i = 0; i < document.getElementsByName('userDiv').length; i++) {
            const element = document.getElementsByName('userDiv')[i];
            const name = element.querySelector('h2').textContent;
            if (name.indexOf(searchPhrase) >= 0) {
                newMain.appendChild(document.getElementsByName('userDiv')[i]);
            }
        }
        document.getElementsByName('OriginalMain')[0].remove();
        document.body.appendChild(newMain);
    },
    createUserList: (data) => {
        const userList = document.createElement('div');

        for (let i = 0; i < data.results.length; i++) {
            const user = data.results[i];
            const userHeading = document.createElement('h2');
            userHeading.textContent = `${user.name.title} ${user.name.first} ${user.name.last}`

            const userImage = document.createElement('img');
            userImage.src = `${user.picture.thumbnail}`;

            const userDiv = document.createElement('div');
            userDiv.setAttribute("name", "userDiv");
            userDiv.appendChild(userHeading);
            userDiv.appendChild(userImage);

            userList.appendChild(userDiv);
        }
        return userList;
    },
    getCompanyName : () => {
        return "SALT";
    },
    removeDivByName: (divName) => {
        let theDiv = document.getElementsByName(divName)[0];
        if(theDiv){
            theDiv.remove();
        }
    },
    AddListInMain : (times) => {
        let content = "";
        for (let i = 1; i <= times; i++) {
            if(i == 1){
                content += "<ul>";
            }
            content += "<li>Lista elem " + i + "</li>";
            if(i == times){
                content += "</ul>";
            }
        }
        document.getElementsByTagName("main")[0].innerHTML += content;
    },
    addListInMainByMarcus : (numberOfListItems) => {
        const ulElement = document.createElement('ul');
      
        for (let i = 0; i < numberOfListItems; i++) {
          const liItem = document.createElement('li');
          liItem.textContent = `Item #${i+1}`
      
          ulElement.appendChild(liItem);
        }
      
        const main = document.querySelector('main');
        main.appendChild(ulElement);
    },
    resultAdder : () => {
        let elements = document.querySelectorAll(".mainResult");
        for (let i = 0; i < elements.length; i++) {
            const el = elements[i].textContent;
            if(Number.isNaN(el)){ // Number.isNaN doesn't seen to get the a random string is not a number...
                for (let j = 0; j < elements[i].classList.length; j++) {
                    const element = array[j];
                    elements[i].classList.remove(element);
                }
            } else if(Number(el) < 0){
                elements[i].classList.add('negativeResult');
            } else {
                elements[i].classList.add('positiveResult');
            }
        }
        
    },
    invertColorsOfResults: () => {
        const mainResultElements = document.querySelectorAll('.mainResult');

        for (let i = 0; i < mainResultElements.length; i++) {
            const element = mainResultElements[i];
            // console.log(element.textContent);

            if(element.classList.contains('positiveResult')){
            element.classList.remove('positiveResult');
            element.classList.add('negativeResult');
            continue;
            }

            if(element.classList.contains('negativeResult')){
            element.classList.remove('negativeResult');
            element.classList.add('positiveResult');
            continue;
            }
        }
    }
}