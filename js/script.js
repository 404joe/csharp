// ******* OnScroll indicator *******
document.body.onscroll = function () {
  ScrollIndicator()
}

// document.body.addEventListener("scroll", ScrollIndicator());
function ScrollIndicator() {
  var winScroll = document.body.scrollTop || document.documentElement.scrollTop;
  var height = document.documentElement.scrollHeight - document.documentElement.clientHeight;
  var scrolled = (winScroll / height) * 100;
  var el = document.getElementById('scroll').style.setProperty('--progress', Math.round(scrolled) + '%');
}
 

// ******* Copy button *******
var copybtn = '<svg xmlns="http://www.w3.org/2000/svg" width=22 height=22 viewBox="0 0 32 32" onclick="handleCopy"> \
                              <path d="M29 4h-9c0-2.209-1.791-4-4-4s-4 1.791-4 4h-9c-0.552 0-1 0.448-1 1v26c0 0.552 0.448 1 1 1h26c0.552 0 1-0.448 1-1v-26c0-0.552-0.448-1-1-1zM16 2c1.105 0 2 0.895 2 2s-0.895 2-2 2c-1.105 0-2-0.895-2-2s0.895-2 2-2zM28 30h-24v-24h4v3c0 0.552 0.448 1 1 1h14c0.552 0 1-0.448 1-1v-3h4v24z"></path> \
                              <path d="M14 26.828l-6.414-7.414 1.828-1.828 4.586 3.586 8.586-7.586 1.829 1.828z"></path> \
                            </svg>' ;
                            
var copychk = '<svg xmlns="http://www.w3.org/2000/svg" width=22 height=22 viewBox="0 0 32 32" > \
                              <path d="M27 4l-15 15-7-7-5 5 12 12 20-20z"></path> \
                            </svg>' ;
 
function copyToClipboard(text) {
  var textarea = document.createElement('textarea');
  textarea.value = text;
  document.body.appendChild(textarea);
  textarea.select();
  document.execCommand('copy');
  document.body.removeChild(textarea);
}
 
function handleCopy(e) {
  var tgn = e.target.tagName.toUpperCase();
  var el = (tgn == 'BUTTON') ? e.target : ( (tgn == 'SVG') ?  e.target.parentElement : e.target.parentElement.parentElement );
  copyToClipboard(el.previousElementSibling.innerText);
  el.innerHTML = copychk;
  setTimeout( function() { el.innerHTML = copybtn; }, 2000);
}

document.addEventListener('DOMContentLoaded', function() {
  var preTags = document.getElementsByTagName('pre');
  
  for (var i = 0; i < preTags.length; i++) {
    var preTag = preTags[i];
    var cb = document.createElement('button');
    cb.innerHTML = copybtn;
    cb.classList.add('copy-button');
    cb.classList.add('no-print');
    cb.setAttribute('aria-label', 'Copy');
    
    cb.addEventListener('click', handleCopy );
    preTag.insertAdjacentElement('afterend', cb);
  }

});