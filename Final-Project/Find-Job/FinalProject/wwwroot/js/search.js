$(document).ready(function () {
    //Search
    let inputLoc = $('#location input');
    $('#search').keyup(function () {
        let search = $(this).val();
        $.ajax({
            url: '/Blog/Search/' + search,
            type: 'Get',
            success: function (response) {
                $('.blogs').remove();
                $('.blog-side .col-lg-8').prepend(response);
                if (search != "") {
                    window.history.pushState('', '', '/Blog/Search?search=' + search);
                    $('.pagination').hide();
                } else {
                    window.history.pushState('', '', '/Blog');
                    $('.pagination').show();
                }
            }
        })
    })
    $('#employer').keyup(function () {
        let search = $(this).val();
        $.ajax({
            url: '/Employer/Search?search=' + search,
            type: 'Get',
            success: function (response) {
                $('.employers').remove();
                $('.col-lg-9 .right-section').append(response);
                console.log(response);
                if (search != "") {
                    window.history.pushState('', '', '/Employer/Search?search=' + search);
                    $('.pagination').hide();
                } else {
                    window.history.pushState('', '', '/Employer');
                    $('.pagination').show();
                }
            }
        })
    })
    $('#sort').change(function () {
        let sort = $(this).val();
        $.ajax({
            url: '/' + controller + '/Sort/'+ sort,
            type: 'Get',
            success: function (response) {
                $('.' + controller.toLowerCase() + 's').remove();
                $('.right-section').append(response);
            }
        })
    })

    let controller = $('#controller').val();
    let action = $('#action').val();
    if (controller == 'Job' && action == 'SearchFromHome') {
        window.history.pushState('', '', '/Job');
    }
    $('.findJob').click(function (e) {
        let route;
        let search = $('#job').val();
        if (search == '' && inputLoc.val() != '') {
            route = '/Job/SearchFromHome/ ' + '/' + inputLoc.val();
        }
        else if (search != '' && inputLoc.val() == '') {
            route = '/Job/SearchFromHome/' + search;
        } else if (search != '' && inputLoc.val() != '') {
            route = '/Job/SearchFromHome/' + search + '/' + inputLoc.val();
        } else {
            route = '/Job';
        }
        window.location.replace(route);

    });

    let searchInput = $('.left-section .form-control');
    let select1 = $('.js-example-basic-single').eq(0);
    let select2 = $('.js-example-basic-single').eq(1);
    let type = $('input:radio[name=jobType]');
    let date = $('input:radio[name=DataPosted]');
    let experience = $('input:radio[name=Experince]');
    let salary = $('input:radio[name=Salary]');
    let checkedDate = $('input:radio[name=DataPosted]:checked').val();
    let checkedType = $('input:radio[name=jobType]:checked').val();
    let checkedExp = $('input:radio[name=Experince]:checked').val();
    let checkedSalary = $('input:radio[name=Salary]:checked').val();
    searchInput.keyup(function (e) {
        let text = $(this).val();
        let route;
        if (text == '') {
            route = '/Job/ ' + '/' + select1.val() + '/' + select2.val() +
                '/' + checkedType + '/' + checkedDate + '/' + checkedExp + '/' + checkedSalary;
        } else {
            route = '/Job/' + text + '/' + select1.val() + '/' + select2.val() +
                '/' + checkedType + '/' + checkedDate + '/' + checkedExp + '/' + checkedSalary;
        }
        $.ajax({
            url: route,
            type: 'Get',
            success: function (response) {
                $('.jobs').remove();
                $('.col-lg-8 .right-section').append(response);
            }
        })
    })
    select1.change(function () {
        let location = $(this).val();
        let route;
        if (searchInput.val() == "") {
            route = '/Job/ ' + '/' + location + '/' + select2.val() +
                '/' + checkedType + '/' + checkedDate + '/' + checkedExp + '/' + checkedSalary;
        } else {
            route = '/Job/' + searchInput.val() + '/' + location + '/' + select2.val() +
                '/' + checkedType + '/' + checkedDate + '/' + checkedExp + '/' + checkedSalary;
        }
        $.ajax({
            url: route,
            type: 'Get',
            success: function (response) {
                $('.jobs').remove();
                $('.col-lg-8 .right-section').append(response);
            }
        })

    });
    select2.change(function () {
        let category = $(this).val();
        let route;
        if (searchInput.val() == "") {
            route = '/Job/ ' + '/' + select1.val() + '/' + select2.val() +
                '/' + checkedType + '/' + checkedDate + '/' + checkedExp + '/' + checkedSalary;
        } else {
            route = '/Job/' + searchInput.val() + '/' + select1.val() + '/' + category +
                '/' + checkedType + '/' + checkedDate + '/' + checkedExp + '/' + checkedSalary;
        }
        $.ajax({
            url: route,
            type: 'Get',
            success: function (response) {
                $('.jobs').remove();
                $('.col-lg-8 .right-section').append(response);
            }
        })
    });

    type.change(function () {
        let route;
        if (searchInput.val() == "") {
            route = '/Job/ ' + '/' + select1.val() + '/' + select2.val() +
                '/' + $(this).val() + '/' + checkedDate + '/' + checkedExp + '/' + checkedSalary;
        } else {
            route = '/Job/' + searchInput.val() + '/' + select1.val() + '/' + select2.val() +
                '/' + $(this).val() + '/' + checkedDate + '/' + checkedExp + '/' + checkedSalary;
        }
        $.ajax({
            url: route,
            type: 'Get',
            success: function (response) {
                $('.jobs').remove();
                $('.col-lg-8 .right-section').append(response);
            }
        })
    });
    date.change(function () {
        let route;
        if (searchInput.val() == "") {
            route = '/Job/ ' + '/' + select1.val() + '/' + select2.val() +
                '/' + checkedType + '/' + $(this).val() + '/' + checkedExp + '/' + checkedSalary;
        } else {
            route = '/Job/' + searchInput.val() + '/' + select1.val() + '/' + select2.val() +
                '/' + checkedType + '/' + $(this).val() + '/' + checkedExp + '/' + checkedSalary;
        }
        $.ajax({
            url: route,
            type: 'Get',
            success: function (response) {
                $('.jobs').remove();
                $('.col-lg-8 .right-section').append(response);
            }
        })
    });
    experience.change(function () {
        let route;
        if (searchInput.val() == "") {
            route = '/Job/ ' + '/' + select1.val() + '/' + select2.val() +
                '/' + checkedType + '/' + checkedDate + '/' + $(this).val() + '/' + checkedSalary;
        } else {
            route = '/Job/' + searchInput.val() + '/' + select1.val() + '/' + select2.val() +
                '/' + checkedType + '/' + checkedDate + '/' + $(this).val() + '/' + checkedSalary;
        }
        $.ajax({
            url: route,
            type: 'Get',
            success: function (response) {
                $('.jobs').remove();
                $('.col-lg-8 .right-section').append(response);
            }
        })
    });
    salary.change(function () {
        let route;
        if (searchInput.val() == "") {
            route = '/Job/ ' + '/' + select1.val() + '/' + select2.val() +
                '/' + checkedType + '/' + checkedDate + '/' + checkedExp + '/' + $(this).val();
        } else {
            route = '/Job/' + searchInput.val() + '/' + select1.val() + '/' + select2.val() +
                '/' + checkedType + '/' + checkedDate + '/' + checkedExp + '/' + $(this).val();
        }
        $.ajax({
            url: route,
            type: 'Get',
            success: function (response) {
                $('.jobs').remove();
                $('.col-lg-8 .right-section').append(response);
            }
        })
    });
    //Search
})