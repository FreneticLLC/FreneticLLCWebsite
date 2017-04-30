/*var main=function()
{

}
*/
/*
function detectmob() { 
 if( navigator.userAgent.match(/Android/i)
 || navigator.userAgent.match(/webOS/i)
 || navigator.userAgent.match(/iPhone/i)
 || navigator.userAgent.match(/iPad/i)
 || navigator.userAgent.match(/iPod/i)
 || navigator.userAgent.match(/BlackBerry/i)
 || navigator.userAgent.match(/Windows Phone/i)
 ){
    return true;
  }
 else {
    return false;
  }
}*/

window.onresize = function(event) {
	resizeDiv();
}


function resizeDiv() {
	vpw = $(window).width();
	vph = $(window).height();

	//m=detectmob();

	$('.landingpage').css({height:vph+"px"});

	sectwooff = $('#section2').offset().top;
}

var scrollf=function(){
	var s = window.scrollY;

	// NOTE: Parallax is awkward.
	/*
	if (!m)
	{
		thisoffset=0
		$('.paralaxbg').each(function(){thisoffset=$(this).offset()}).css({"background-position-y":((s/2)-(thisoffset.top))+"px"})
	}
	*/

	if (s >= sectwooff)
	{
		$('header').css({opacity:1})
	}
	else
	{
		$('header').css({opacity:0})
	}
}

window.addEventListener('scroll', scrollf, false);

//$(document).ready(main)
$(document).ready(resizeDiv);
