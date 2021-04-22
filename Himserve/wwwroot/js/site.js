function displayAboutSection(divId) {
    //menu division
    var menuWorkAreas = document.getElementById('menu-work-areas');
    var menustaff = document.getElementById('menu-staffs');
    var menupartners = document.getElementById('menu-partners');

    //content division
    var _workAreas = document.getElementById('work-areas');
    var _staffs = document.getElementById('staffs');
    var _partners = document.getElementById('partners'); 

    if (divId == "work-areas") {
        _staffs.style.display = "none";
        _partners.style.display = "none";
        menuWorkAreas.classList.add("active");
        menustaff.classList.remove("active");
        menupartners.classList.remove("active");
        _workAreas.style.display = "block";
    }
    else if (divId == "staffs") {
        _workAreas.style.display = "none";
        _partners.style.display = "none";
        menustaff.classList.add("active");
        menuWorkAreas.classList.remove("active");
        menupartners.classList.remove("active");
        _staffs.style.display = "block";
    }
    else if (divId == "partners") {
        _staffs.style.display = "none";
        _partners.style.display = "none";
        menupartners.classList.add("active");
        menustaff.classList.remove("active");
        menuWorkAreas.classList.remove("active");
        _partners.style.display = "block";
    }
}
