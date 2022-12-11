function toggleDropdown(id) {
  var elemet = document.getElementById(id);
  if (elemet.style.display === "block") elemet.style.display = "none";
  else elemet.style.display = "block";
}

$("#showcaseuploadbutton").on("click", function () {
  $("#hiddenshowcaseimageinput").trigger("click");
});

$("#showcase-image-upload-box").on("click", function () {
  $("#hiddenshowcaseimageinput").trigger("click");
});

$('#hiddenshowcaseimageinput').on('change', function(){
  let fileReader = new FileReader();
  fileReader.onload = function(){
    $("#showcase-preview").attr("src", fileReader.result);
  };
  let file = $("#hiddenshowcaseimageinput")[0].files[0];
  fileReader.readAsDataURL(file);
  //$("#showcase-preview").attr('src', 
    //$("#hiddenshowcaseimageinput")[0].files.length ? $('#hiddenshowcaseimageinput').val() : "");
});

$("#uploadshowcaseimagebutton").on('click', function(){
  let image = $("#hiddenshowcaseimageinput")[0].files[0].name;
  let xhr = new XMLHttpRequest();
  //query-12
  let query = "INSERT INTO homepage (gameid, type, serial) VALUES (0, '"+image+"', 0);";
  xhr.open('GET', '../../../Hexa/Model/model.php?query='+query, true);
  //xhr.send();
}); 

function showmenu() {
    $(".hide").hide();
    $("#showbutton").hide();
    $("#hidebutton").show();
}

function hidemenu() {
  $(".hide").show();
  $("#showbutton").show();
  $("#hidebutton").hide();
}

$("#remove-employee-profile-edit-details-box").on('click',
  function(){
    $("#employee-manage-info").empty();
  }
);

$("#remove-customer-profile-edit-details-box").on('click',
  function(){
    $("#customer-manage-info").empty();
  }
);

$("#remove-developer-profile-edit-details-box").on('click',
  function(){
    $("#developer-manage-info").empty();
  }
);




//profile
$('input[name="fname"]').on("input", validateFirstName);
function validateFirstName() {
  console.log($('[name="fname"]').val());
  if ($('[name="fname"]').val() == "")
    $("#firstnameerror").html("Input Field cannot be empty");
  else if (/^[a-zA-Z]+$/.test($('[name="fname"]').val()) == false)
    $("#firstnameerror").html("Name cannot contain any number or symbol");
  else{ 
		$("#firstnameerror").html("");
		return true;
	}
	return false;
};

$('input[name="lname"]').on("input", validateLastName);
function validateLastName(){
  console.log($('[name="lname"]').val());
  if ($('[name="lname"]').val() == "")
    $("#lastnameerror").html("Input Field cannot be empty");
  else if (/^[a-zA-Z]+$/.test($('[name="lname"]').val()) == false)
    $("#lastnameerror").html("Name cannot contain any number or symbol");
  else {
		$("#lastnameerror").html("");
		return true;
	}
	return false;
};

$('input[name="uname"]').on("input", validateUserName);
function validateUserName(){
  console.log($('[name="uname"]').val());
  if ($('[name="uname"]').val() == "")
    $("#usernameerror").html("Input Field cannot be empty");
  else if (/^[a-zA-Z]+[a-zA-Z0-9]*$/.test($('[name="uname"]').val()) == false)
    $("#usernameerror").html("Name cannot contain any number or symbol");
  else {
		$("#usernameerror").html("");
		return true;
	}
	return false;
};

$('input[name="email"]').on("input", validateEmail);
function validateEmail(){
  console.log($('[name="email"]').val());
  if ($('[name="email"]').val() == "")
    $("#emailerror").html("Input Field cannot be empty");
  else if(/^[a-zA-Z][a-zA-Z0-9_]+[@]+[a-zA-Z]+[.]+[a-zA-Z.]+[a-zA-Z]$/.test($('[name="email"]').val()) == false)
    $("#emailerror").html("Invalid Email Address");
  else {
		$("#emailerror").html("");
		return true;
	}
	return false;
};

$('input[name="password"]').on("input", validatePassword);
function validatePassword(){
  console.log($('[name="password"]').val());
  if ($('[name="password"]').val() == "")
    $("#passworderror").html("Input Field cannot be empty");
  else if ($('[name="password"]').val().length < 8)
    $("#passworderror").html("Password length must be atleast 8");
  else if (/[a-zA-z]/.test($('[name="password"]').val()) == false)
    $("#passworderror").html("Password must contain atleast one alphabet");
  else if (/[0-9]/.test($('[name="password"]').val()) == false)
    $("#passworderror").html("Password must contain atleast one number");
  else if (/[!@#$%^&*]/.test($('[name="password"]').val()) == false)
    $("#passworderror").html("Password must contain atleast one character");
  else {
		$("#passworderror").html("");
		return true;
	}
	return false;
};

$('input[name="dateofbirth"]').on("input", validateDateOfBirth);
function validateDateOfBirth(){
	var today = new Date();
	var date=today.getFullYear()+'-';
	if((today.getMonth()+1)<10) 
		date+='0'+(today.getMonth()+1);
	else 
		date+=today.getMonth()+1;
	date+='-';
	if(today.getDate()<10) 
		date+='0'+today.getDate();
	else
		date+=today.getDate();
	if($('[name="dateofbirth"]').val()=='')
		$("#dateofbirtherror").html("Select a Date");
	else if($('[name="dateofbirth"]').val()>date)
		$("#dateofbirtherror").html("Invalid Date");
	else{
		$("#dateofbirtherror").html("");
		return true;
	}
	return false;
};

$('input[name="address"]').on("input", validateAddress);
function validateAddress(){
	if($('[name="address"]').val()=="")
    	$("#addresserror").html("Input Field cannot be empty");
	else{
		$("#addresserror").html("");
	}
	return false;
};

$('input[name="region"]').on("change", validateRegion);
  function validateRegion() {
    if($('[name="region"]').val() == "")
      $("#regionerror").html("Input Field cannot be empty");
    else {
      $("#regionerror").html("");
      return true;
    }
  return false;
};

//if(validateFirstName() || validateLastName() || validateUserName() || validateEmail() || validatePassword() || validateDateOfBirth() || validateAddress() || validateRegion()) {}

$("#edit-profile-submit-button").on('click', function(){
	$("#profile-edit-submit-hidden").click();
});
