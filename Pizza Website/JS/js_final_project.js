function getReceipt() {
	text1 = "";
	price = "";
	var runningTotal = 0;
	var sizeTotal = 0;
	var sizeArray = document.getElementsByClassName("size");
	for (var i = 0; i < sizeArray.length; i++) {
		if (sizeArray[i].checked) {
			var selectedSize = sizeArray[i].value;
			text1 = text1+selectedSize+"<br>";
		}
	}
	if (selectedSize === "Personal Pizza") {
		sizeTotal = 6;
		price += "Size: " + "$" + sizeTotal + ".00<br/>";
	} else if (selectedSize === "Medium Pizza") {
		sizeTotal = 10;
		price += "Size: " + "$" + sizeTotal + ".00<br/>";
	} else if (selectedSize === "Large Pizza") {
		sizeTotal = 14;
		price += "Size: " + "$" + sizeTotal + ".00<br/>";
	} else if (selectedSize === "Extra Large Pizza") {
		sizeTotal = 16;
		price += "Size: " + "$" + sizeTotal + ".00<br/>";
	}
	runningTotal = sizeTotal;
	getMeat(runningTotal,text1,price);
};
function getMeat(runningTotal,text1,price) {
	var runningTotal = runningTotal;
	var meatTotal = 0;
	var selectedMeat = [];
	var meatArray = document.getElementsByClassName("meats");
	for (var j = 0; j < meatArray.length; j++) {
		if (meatArray[j].checked) {
			selectedMeat.push(meatArray[j].value);
		}
	}
	var meatCount = selectedMeat.length;
	if (meatCount > 1) {
		meatTotal = (meatCount - 1);
	} else {
		meatTotal = 0;
	}
	runningTotal = (runningTotal + meatTotal);
  for (var j = 0; j < selectedMeat.length; j++) {
    text1 += selectedMeat[j]+"<br>";
    meatCount -= 1;
	}
    price += "Meats: $" + (meatTotal) + ".00<br>";
	getVeggie(runningTotal,text1,price);
};
function getVeggie(runningTotal,text1,price) {
	var veggieTotal = 0;
	var selectedVeggie = [];
	var veggieArray = document.getElementsByClassName("veggies");
	for (var j = 0; j < veggieArray.length; j++) {
		if (veggieArray[j].checked) {
			selectedVeggie.push(veggieArray[j].value);
		}
	}
	var veggieCount = selectedVeggie.length;
	if (veggieCount >= 2) {
		veggieTotal = (veggieCount - 1);
	} else {
		veggieTotal = 0;
	}
	runningTotal = (runningTotal + veggieTotal);
  for (var j = 0; j < selectedVeggie.length; j++) {
      text1 += selectedVeggie[j]+"<br>";
      veggieCount -= 1;
		}
      price += "Veggies: $" + (veggieTotal) + ".00<br>";
	getCheese(runningTotal,text1,price);
};
function getCheese(runningTotal,text1,price) {
	var cheeseTotal = 0;
	var selectedCheese = [];
	var cheeseArray = document.getElementsByClassName("cheese");
	for (var j = 0; j < cheeseArray.length; j++) {
		if (cheeseArray[j].checked) {
			selectedCheese = cheeseArray[j].value;
		}
		if (selectedCheese === "Extra Cheese") {
			cheeseTotal = 3;
		}
	}
	price += "Cheese: $" + cheeseTotal + ".00<br/>";
	text1 = text1+selectedCheese+"<br>";
	runningTotal = (runningTotal + cheeseTotal);
	getSauce(runningTotal,text1,price);
};
function getSauce(runningTotal,text1,price) {
	var sauceArray = document.getElementsByClassName("sauce");
	for (var j = 0; j < sauceArray.length; j++) {
		if (sauceArray[j].checked) {
			selectedSauce = sauceArray[j].value;
			text1 += sauceArray[j].value + "<br>";
		}
	}
	price += "Sauce: $" + "0.00" + "<br>";
	getCrust(runningTotal,text1,price)
};
function getCrust(runningTotal,text1,price) {
	var crustTotal = 0;
	var selectedCrust;
	var crustArray = document.getElementsByClassName("crust");
	for (var j = 0; j < crustArray.length; j++) {
		if (crustArray[j].checked) {
			selectedCrust = crustArray[j].value;
			text1 = text1 + selectedCrust + "<br>";
		}
		if (selectedCrust === "Cheese Stuffed Crust") {
			crustTotal = 3;
		}
	}
	runningTotal = (runningTotal + crustTotal);
	price += "Crust: " + "$" + crustTotal + ".00<br/>";
	document.getElementById("cart").style.opacity=1;
	document.getElementById("showText1").innerHTML=text1;
	document.getElementById("showprice").innerHTML= price;
	document.getElementById("totalPrice2").innerHTML = "</h3>$"+runningTotal+".00"+"</h3>";
};
function clearAll() {
	document.getElementById("frmMenu").reset();
	document.getElementById("cart").style.opacity=0;
	document.getElementById("showText1").innerHTML="";
	document.getElementById("showprice").innerHTML= "";
	document.getElementById("totalPrice2").innerHTML = "";
};
