var current = 0;
var time = 3000;
var images = [];
var interval = null;

images[0] ='images/festivalimg.png';
images[1] ='images/festivalimg1.jpg';
images[2] ='images/festivalimg2.jpg';
images[3] ='images/festivalimg3.jpg';
images[4] ='images/festivalimg4.jpg';
images[5] ='images/festivalimg5.jpg';
images[6] ='images/festivalimg6.jpg';
images[7] ='images/festivalimg7.jpg';
images[8] ='images/festivalimg8.jpg';
    
function init() {
    placeSlide();
}

function resetInterval(){
    if(interval != null) clearInterval(interval);
    interval = setInterval(function() { next() }, time);
}

function placeSlide() {
    document.slide.src = images[current];
    resetInterval();
}

function next()
{
    if(current < images.length -1)
    {
       current++;
    }
    else
    {
       current = 0;
    }
    placeSlide();
}

window.onload = init();