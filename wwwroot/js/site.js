﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
	(function(w,d,s,r,k,h,m){
	if(w.performance && w.performance.timing && w.performance.navigation) {
		w[r] = w[r] || function () { (w[r].q = w[r].q || []).push(arguments) };
	h=d.createElement('script');h.async=true;h.setAttribute('src',s+k);
	d.getElementsByTagName('head')[0].appendChild(h);
	(m = window.onerror),(window.onerror = function (b, c, d, f, g) {
		m && m(b, c, d, f, g), g || (g = new Error(b)), (w[r].q = w[r].q || []).push(["captureException", g]);})
	}
})(window,document,'//static.site24x7rum.eu/beacon/site24x7rum-min.js?appKey=','s247r','bfff4dc41b0cfd7862bb4bc64240bfa8');
