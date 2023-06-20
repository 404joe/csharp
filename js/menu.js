var initscroll = function () {
	gumshoe.init({
		offset: 100 
	});
	// gumshoe.setDistances();

	var scroll = new SmoothScroll('a[href*="#"]', {
		offset: 100 // header: '[data-scroll-header]'    
	});	
}


// add event listener to menu button
var toggle = document.getElementById("menu-toggle");

// toggle.addEventListener("click", MainMenu, false);

var menu 	  = document.getElementById("toggled");

getStyle = function (el, prop) {
    if (typeof getComputedStyle !== 'undefined') {
        return getComputedStyle(el, null).getPropertyValue(prop);
    } else {
        return el.currentStyle[prop];
    }
}


// function to change the background color of the menu button and the display value of the menu
function MainMenu() {
	/*
	var menuStyle = window.getComputedStyle(menu);
	var display   = menuStyle.getPropertyValue('display');
	*/
	var display = getStyle(menu, 'display');
	
	if (display == 'none') {
		/*toggle.style.backgroundColor = "#19A347";*/
		toggle.innerHTML = '&#x00D7'; // <!-- Menu &#x2261; &#x00D7; ≡ ˟ -->
		menu.style.display = "block";
	} else {
		/*toggle.style.backgroundColor = "transparent";*/
		toggle.innerHTML = '&#x2261'; // <!-- Menu &#x2261; &#x00D7; ≡ ˟ -->
		menu.style.display = "none";
	};
};

// function to change the background color of the menu button and the display value of the menu
function closeMenu() {
	
	// e.preventDefault(); // fix scroll to div id="messages" on link #messages
	/*
	var menuStyle = window.getComputedStyle(menu);
	var display   = menuStyle.getPropertyValue('display');
	*/
	var display = getStyle(menu, 'display');
	
	if (display != 'none') {
		/*toggle.style.backgroundColor = "transparent";*/		
		toggle.innerHTML = '&#x2261'; // <!-- Menu &#x2261; &#x00D7; ≡ ˟ -->
		menu.style.display = "none";
	};
};

