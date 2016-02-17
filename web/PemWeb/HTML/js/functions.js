// JQuery extension to set, reset, invert, disable and enable
(function ($) {
    $.fn.extend({
        set: function () {
            return this.each(function () {
                $(this).addClass("active");
            });
        }
    }),

$.fn.extend({
    reset: function () {
        return this.each(function () {
            $(this).removeClass("active");
        });
    }
}),
$.fn.extend({
    invert: function () {
        return this.each(function () {
            $(this).toggleClass("active");
        });
    }
});
    $.fn.extend({
        disable: function () {
            return this.each(function () {
                $(this).attr("disabled", "disabled");
            });
        }
    });
    $.fn.extend({
        enable: function () {
            return this.each(function () {
                $(this).removeAttr("disabled");
            });
        }
    });
})(jQuery);