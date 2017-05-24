(function ($) {
    var $window = $(window); var windowHeight = $window.height(); $window.resize(function () { windowHeight = $window.height() }); $.fn.parallax = function (xpos, speedFactor, outerHeight) {
        var $this = $(this); var getHeight; var firstTop; var paddingTop = 0; if (outerHeight) { getHeight = function (jqo) { return jqo.outerHeight(!0) } } else { getHeight = function (jqo) { return jqo.height() } }
        if (arguments.length < 1 || xpos === null) xpos = "50%"; if (arguments.length < 2 || speedFactor === null) speedFactor = 0.1; if (arguments.length < 3 || outerHeight === null) outerHeight = !0; function update() {
            var pos = $window.scrollTop(); $this.each(function (i) {
                var $element = $(this); var top = $element.offset().top; var height = getHeight($element); firstTop = $element.offset().top; if (top + height < pos || top > pos + windowHeight) { return }
                $element.css('backgroundPosition', xpos + " " + Math.round((firstTop - pos) * speedFactor) + "px")
            })
        }
        $window.bind('scroll', update).resize(update); update()
    }
})(jQuery)