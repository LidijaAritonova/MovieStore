$(function () {
   
    $("form[name='moviecreate']").validate({
        success: "valid",
        onkeyup: true,
        errorClass: "error",
        focusInvalid: true,
        highlight: function (element, errorClass) {
            $(element).fadeOut(function () {
                $(element).fadeIn();
                $(element).addClass(errorClass);
            });
        },
        rules: {
            Title: {
                required: true,
                minlength: 2
            },
            GenreID: {
                required: true,
                min: 1
            },
            DirectorID: {
                required: true,
                min: 1
            },
            ProducerID: {
                required: true,
                min: 1
            },
            PublisherID: {
                required: true,
                min: 1
            },
            Cast: {
                required: true,
                minlength: 2
            },
            Budget: {
                required: true,
                minlength: 2
            },
            Released: {
                required: true,
                number: true,
                digits: true
            },
            PriceForRent: {
                required: true,
                number: true,
                digits: true
            },
            PriceForBuy: {
                required: true,
                number: true,
                digits: true
            },
            Synopsis: "required",
            CreateDirectorName: {
                required: true,
                minlength: 2
            },
            CreateProducerName: {
                required: true,
                minlength: 2
            },
            CreatePublisherName: {
                required: true,
                minlength: 2
            },
            CreatePublisherCountry: {
                required: true,
                minlength: 2
            }
        },
        messages: {
            Title: {
                required: "Please enter title",
                minlength: jQuery.validator.format("At least {0} characters required!")
            },
            GenreID: {
                required: "Please select genre",
                min: "Please select one genre from the dropdown"
            },
            DirectorID: {
                required: "Please select director",
                min: "Please select one director from the dropdown"
            },
            ProducerID: {
                required: "Please select producer",
                min: "Please select one producer from the dropdown"
            },
            PublisherID: {
                required: "Please select publisher",
                min: "Please select one publisher from the dropdown"
            },
            Cast: {
                required: "Please enter cast",
                minlength: jQuery.validator.format("At least {0} characters required!")
            },
            Budget: {
                required: "Please enter budget",
                minlength: jQuery.validator.format("At least {0} characters required!")
            },
            Released: {
                required: "Please enter year of released",
                number: "Please enter numbers only",
                digits: "Only digits are allowed in this field"
            },
            PriceForRent: {
                required: "Please enter price for rent",
                number: "Please enter numbers only",
                digits: "Only digits are allowed in this field"
            },
            PriceForBuy: {
                required: "Please enter price for buy",
                number: "Please enter numbers only",
                digits: "Only digits are allowed in this field"
            },
            Synopsis: "Please enter synopsis",
            CreateDirectorName: {
                required: "Please enter name of director",
                minlength: jQuery.validator.format("At least {0} characters required!")
            },
            CreateProducerName: {
                required: "Please enter name of producer",
                minlength: jQuery.validator.format("At least {0} characters required!")
            },
            CreatePublisherName: {
                required: "Please enter name of publisher",
                minlength: jQuery.validator.format("At least {0} characters required!")
            },
            CreatePublisherCountry: {
                required: "Please enter country of publisher",
                minlength: jQuery.validator.format("At least {0} characters required!")
            }
        },
        submitHandler: function (form) {
            form.submit();
        }
    }),
        $("form[name='usercreate']").validate({
            success: "valid",
            onkeyup: true,
            errorClass: "error",
            focusInvalid: true,
            highlight: function (element, errorClass) {
                $(element).fadeOut(function () {
                    $(element).fadeIn();
                    $(element).addClass(errorClass);
                });
            },

            rules: {

                Name: {
                    required: true,
                    minlength: 2,
                    maxlength: 25
                },


                Email: {
                    required: true,
                    email: true
                },
                Password: {
                    required: true,
                    minlength: 6
                },
                RoleName: "required"
            },


            // Specify validation error messages
            messages: {
                Name: {
                    required: "Please enter name",
                    minlength: jQuery.validator.format("At least {0} characters required!"),
                    maxlength: jQuery.validator.format("At max {0} characters required!")
                },

                Email: {
                    required: "Please enter email",
                    email: "Please enter a valid email address, example: you@yourdomain.com"
                },
                Password: {
                    required: "Please enter password",
                    minlength: jQuery.validator.format("Your password must be at least {0} characters long")
                },
                RoleName: {
                    required: "Please select role",

                },
                // Make sure the form is submitted to the destination defined
                // in the "action" attribute of the form when valid
                submitHandler: function (form) {
                    form.submit();
                }
            });

    $("form[name='directorcreate']").validate({
        success: "valid",
        onkeyup: true,
        errorClass: "error",
        focusInvalid: true,
        highlight: function (element, errorClass) {
            $(element).fadeOut(function () {
                $(element).fadeIn();
                $(element).addClass(errorClass);
            });
        },

        rules: {

            Name: {
                required: true,
                minlength: 2,
                maxlength: 25
            }
        },

            // Specify validation error messages
        messages: {
            Name: {
                required: "Please enter name",
                minlength: jQuery.validator.format("At least {0} characters required!"),
                maxlength: jQuery.validator.format("At max {0} characters required!")
            },
        }

                // Make sure the form is submitted to the destination defined
                // in the "action" attribute of the form when valid
                submitHandler: function (form) {
                    form.submit();
                }
            }),

        $("form[name='publichercreate']").validate({
            success: "valid",
            onkeyup: true,
            errorClass: "error",
            focusInvalid: true,
            highlight: function (element, errorClass) {
                $(element).fadeOut(function () {
                    $(element).fadeIn();
                    $(element).addClass(errorClass);
                });
            },

            rules: {

                Name: {
                    required: true,
                    minlength: 2,
                    maxlength: 25
                },
                Country: {
                    required: true,
                    minlength: 2,
                    maxlength: 25
                }
            },

                // Specify validation error messages
            messages: {
                Name: {
                    required: "Please enter name",
                    minlength: jQuery.validator.format("At least {0} characters required!"),
                    maxlength: jQuery.validator.format("At max {0} characters required!")
                },
                Country: {
                    required: "Please enter country",
                    minlength: jQuery.validator.format("At least {0} characters required!"),
                    maxlength: jQuery.validator.format("At max {0} characters required!")
                }
            },



                    // Make sure the form is submitted to the destination defined
                    // in the "action" attribute of the form when valid
                    submitHandler: function (form) {
                        form.submit();
                    }
                })

});

  

   
 



    









