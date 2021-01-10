$(document).ready(function () {


    $('#min').keyup(function(){
        $('#max').attr({
            'min': $(this).val()
        });
    })

    $('#max').keyup(function () {
        $('#min').attr({
            'max': $(this).val()
        });
    })

    // navbar section start
    let user = $('.user');
    let dropdown = $('.dropdown');
    user.on('mouseover', function () {
        dropdown.css({
            'display': 'block'
        })
    })

    user.on('mouseleave', function () {
        dropdown.css({
            'display': 'none'
        })
    })
    // navbar section end

    // post button start
    let post = $('.btnPost');
    post.on('mouseover', function () {
        $(this).text('');
        let plus = $('<i></i>');
        plus.addClass('fas fa-plus');
        $(this).append(plus);
    })
    post.on('mouseleave', function () {
        $(this).text('Post a Job');
    })
    //post button end

    // responsive navbar
    let burger = $('.burger-button');
    burger.click(function () {
        $('.dropdown-responsive').slideToggle();
    })
    // responsive

    // tab-menu section start
    // user list tab-menu
    $('.user-nav span').click(function () {
        let data = $(this).attr('data-id');
        $('.userList').each(function () {
            if (data == $(this).attr('data-id')) {
                $(this).removeClass('d-none');
                $('.userList').not(this).addClass('d-none');
            }
        })
        $('.user-nav span').not(this).removeClass('actived');
        $(this).addClass('actived');
    })

    // account list tab-menu
    $('.account-nav span').click(function () {
        let data = $(this).attr('data-id');
        $('.accountList').each(function () {
            if (data == $(this).attr('data-id')) {
                $(this).removeClass('d-none');
                $('.accountList').not(this).addClass('d-none');
            }
        })
        $('.account-nav span').not(this).removeClass('actived');
        $(this).addClass('actived');
    })

    // tab-menu section end

    // custom select input
    $('.down').click(function () {
        DropDownOpen($(this).prev());
    })

    $('.selectList li').click(function () {
        let val = $(this).text();
        $(this).parent().parent().prev().val(val);
        $(this).parent().parent().css({
            'display': 'none'
        })
    })
    $('.selectList').prev().click(function () {
        DropDownOpen($(this).next());
    })
    // custom select input


    // back to top 
    $(window).on('scroll', function () {
        if ($(window).scrollTop() > 100) {
            $('.back-to-top').css({
                'display': 'flex'
            });
        } else {
            $('.back-to-top').hide();
        }
    })
    $('.back-to-top').on('click', function () {
        $(window).scrollTop(0);
    })
    // back to top

    // mark all as read
    let menu = $('.kebab-menu');
    let read = $('.mark-as-read');
    read.click(function () {
        let Id = $(this).parents('.message').prev().val();
        document.location.href = '/Admin/Message/Read?Id=' + Id;
    })
    menu.click(function () {
        $('.menu-item').toggle();
    })

    $('.menu-item').click(function () {
        $(this).hide();
        document.location.href = '/Admin/Message/ReadAll';
    })
    // mark all as read

    //
    $('.next-section').click(function () {
        $(this).parent().parent().hide();
        $(this).parent().parent().next().show();
    });
    $('.prev-section').click(function () {
        $(this).parent().parent().hide();
        $(this).parent().parent().prev().show();
    });
    $('.value').text($('[type=range]').val());
    $('[type=range]').change(function () {
        let val = $(this).val();
        $(this).prev().children('.value').text(val);
    })
    //

    // functions
    function DropDownOpen(elem) {
        if (elem.css('display') == 'none') {
            $('.selectList').css({
                'display': 'none'
            })
            elem.css({
                'display': 'block'
            })
        } else {
            elem.css({
                'display': 'none'
            })
        }
    }
    // functions

})