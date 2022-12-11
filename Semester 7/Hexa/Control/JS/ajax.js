function XHR(method, url, async){
    const p = new Promise(function(resolve, reject){
        let xhr = new XMLHttpRequest();
        xhr.open(method, url, async);
        //xhr.setRequestHeader();
        xhr.send();
        xhr.onreadystatechange = function(){
            if(xhr.readyState==XMLHttpRequest.DONE && xhr.status===200){
                resolve(xhr.responseText);
            }
        }
    });
    return p.then(function(result){
        return JSON.stringify(result);
    });
    //return p;
};

function loadGameDetailsEditor(row) {
    html = `
            <span class="material-icons-round" id="remove-game-profile-edit-details-box">disabled_by_default</span>
            <input id='hidden-input' value='${row["gameid"]}'>

            <label>Title:</label>
            <input type="text" name="title" class="textinput" placeholder="Title..." value="${row["title"]}">

            <label>Publisher:</label>
            <input type="text" name="publisher" class="textinput" placeholder="Publisher..." value="${row["publisher"]}">

            <label>Category:</label>
            <input type="text" name="category" class="textinput" placeholder="Category..." value="${row["category"]}">

            <div class="edit-profile-name-box">
                <span>
                    <label>Price:</label>
                    <input type="text" name="price" class="textinput" placeholder="Price..." value="${row["price"]}">
                </span>
                <span>
                    <label>Discount:</label>
                    <input type="text" name="discount" class="textinput" placeholder="Discount..." value="${row["discount"]}">
                </span>
            </div>

            <label>System Requirment:</label>
            <input type="text" name="systemrequirment" class="textinput" placeholder="System Requirment..." value="${row["systemrequirment"]}">

            <label>Description:</label>
            <input type="text" name="description" class="textinput" placeholder="Description..." value="${row["description"]}">

            <label>Release Date:</label>
            <input type="date" name="releasedate" class="textinput" value="${row["releasedate"]}">

            <label>Status:</label>
            <select name="status-userid" class="textinput" id="status" value="${row["status"]}">
                <option hidden selected>Select an option...</option>
                <option value="Show">Show</option>
                <option value="Hide">Hide</option>
            </select>
            
    `;
    $("div#game-manage-info").html(html);
    $("#remove-game-profile-edit-details-box").on("click", function () {
      $("#game-manage-info").empty();
    });
    $("#save-game-table-management").on("click", saveGameDetailsEditor);

}

function loadNewsDetailsEditor(row) {
    html = `
            <span class="material-icons-round" id="remove-news-profile-edit-details-box">disabled_by_default</span>
            <input id='hidden-input' value='${row["newsid"]}'>

            <label>Title:</label>
            <input type="text" name="title" class="textinput" placeholder="Title..." value="${row["title"]}">

            <label>Publisher:</label>
            <input type="text" name="publisher" class="textinput" placeholder="Publisher..." value="${row["domain"]}">

            <label>Description:</label>
            <input type="text" name="description" class="textinput" placeholder="Description..." value="${row["description"]}">

            <label>Release Date:</label>
            <input type="date" name="releasedate" class="textinput" value="${row["publishdate"]}">

            <label>Status:</label>
            <select name="status-userid" class="textinput" id="status" value="${row["status"]}">
                <option hidden selected>Select an option...</option>
                <option value="published">Published</option>
                <option value="unpublished">Unpublished</option>
            </select>
            
    `;
    $("div#news-manage-info").html(html);
    $("#remove-news-profile-edit-details-box").on("click", function () {
      $("#news-manage-info").empty();
    });
    $("#save-news-table-management").on("click", saveNewsDetailsEditor);

}

function loadEmployeeProfileEditor(row) {
    html = `
    <span class="material-icons-round" id="remove-employee-profile-edit-details-box">disabled_by_default</span>
            <div class="edit-profile-name-box">
                <span>
                    <label>First Name:</label>
                    <input type="text" name="fname" class="textinput" placeholder="first name..." value="`+`${row["firstname"]}`+`">
                    <span class="formerror" id="firstnameerror"></span>
                </span>
                <span>
                    <label>Last Name:</label>
                    <input type="text" name="lname" class="textinput" placeholder="last name..." value="${row["lastname"]}">
                    <span class="formerror" id="lastnameerror"></span>
                </span>
            </div>

            <input id='hidden-input' value='${row["userid"]}'>

            <label>Username:</label>
            <input type="text" name="uname" class="textinput" placeholder="username..." value="${row["username"]}">
            <span class="formerror" id="usernameerror"></span>

            <label>Password:</label>
            <input type="password" name="password" class="textinput" placeholder="password..." value="${row["password"]}">
            <span class="formerror" id="passworderror"></span>

            <label>Email:</label>
            <input type="email" name="email" class="textinput" placeholder="email..." value="${row["email"]}">
            <span class="formerror" id="emailerror"></span>

            <label>Date of Birth</label>
            <input type="date" name="dateofbirth" class="textinput" value="${row["dateofbirth"]}">
            <span class="formerror" id="dateofbirtherror"></span>

            <label>Address:</label>
            <input type="text" name="address" class="textinput" placeholder="address..." value="${row["address"]}">
            <span class="formerror" id="addresserror"></span>

            <label>Country:</label>
            <input type="text" name="country" class="textinput" placeholder="country..." value="${row["country"]}">
            <span class="formerror" id="countryerror"></span>

            <label>Payment ID:</label>
            <input type="text" name="paymentid" class="textinput" placeholder="payment id..." value="${row["paymentid"]}">
            <span class="formerror" id="paymentiderror"></span>

            <label>Status:</label>
            <select name="status-userid" class="textinput" id="status" value="${row["status"]}">
                <option hidden selected>Select an option...</option>
                <option value="Active">Active</option>
                <option value="Inactive">Inactive</option>
                <option value="Banned">Banned</option>
            </select>
            
    `;
    $("div#employee-manage-info").html(html);
    $("#remove-employee-profile-edit-details-box").on("click", function () {
      $("#employee-manage-info").empty();
    });
    $("#save-employee-table-management").on("click", saveEmployeeProfileEditor);

}

function loadCustomerProfileEditor(row) {
    html = `
    <span class="material-icons-round" id="remove-customer-profile-edit-details-box">disabled_by_default</span>
            <div class="edit-profile-name-box">
                <span>
                    <label>First Name:</label>
                    <input type="text" name="fname" class="textinput" placeholder="first name..." value=${row["firstname"]}>
                    <span class="formerror" id="firstnameerror"></span>
                </span>
                <span>
                    <label>Last Name:</label>
                    <input type="text" name="lname" class="textinput" placeholder="last name..." value=${row["lastname"]}>
                    <span class="formerror" id="lastnameerror"></span>
                </span>
            </div>

            <input id='hidden-input' value='${row["userid"]}'>

            <label>Username:</label>
            <input type="text" name="uname" class="textinput" placeholder="username..." value=${row["username"]}>
            <span class="formerror" id="usernameerror"></span>

            <label>Password:</label>
            <input type="password" name="password" class="textinput" placeholder="password..." value=${row["password"]}>
            <span class="formerror" id="passworderror"></span>

            <label>Email:</label>
            <input type="email" name="email" class="textinput" placeholder="email..." value=${row["email"]}>
            <span class="formerror" id="emailerror"></span>

            <label>Date of Birth</label>
            <input type="date" name="dateofbirth" class="textinput" value=${row["dateofbirth"]}>
            <span class="formerror" id="dateofbirtherror"></span>

            <label>Address:</label>
            <input type="text" name="address" class="textinput" placeholder="address..." value=${row["address"]}>
            <span class="formerror" id="addresserror"></span>

            <label>Region:</label>
            <input type="text" name="region" class="textinput" placeholder="region..." value=${row["region"]}>
            <span class="formerror" id="regionerror"></span>

            <label>Country:</label>
            <input type="text" name="country" class="textinput" placeholder="country..." value=${row["country"]}>
            <span class="formerror" id="countryerror"></span>

            <label>Balance:</label>
            <input type="text" name="balance" class="textinput" placeholder="balance..." value=${row["balance"]}>
            <span class="formerror" id="balanceerror"></span>

            <label>Status:</label>
            <select name="status-userid" class="textinput" id="status" value=${row["status"]}>
                <option hidden selected>Select an option...</option>
                <option value="Active">Active</option>
                <option value="Inactive">Inactive</option>
                <option value="Banned">Banned</option>
            </select>
            
    `;
    $("div#customer-manage-info").html(html);
    $("#remove-customer-profile-edit-details-box").on("click", function () {
      $("#customer-manage-info").empty();
    });
    $("#save-customer-table-management").on("click", saveCustomerProfileEditor);

}

function loadDeveloperProfileEditor(row){
    html = `
    <span class="material-icons-round" id="remove-developer-profile-edit-details-box">disabled_by_default</span>
            <div class="edit-profile-name-box">
                <span>
                    <label>First Name:</label>
                    <input type="text" name="fname" class="textinput" placeholder="first name..." value=${row["firstname"]}>
                    <span class="formerror" id="firstnameerror"></span>
                </span>
                <span>
                    <label>Last Name:</label>
                    <input type="text" name="lname" class="textinput" placeholder="last name..." value=${row["lastname"]}>
                    <span class="formerror" id="lastnameerror"></span>
                </span>
            </div>

            <input id='hidden-input' value='${row["userid"]}'>

            <label>Username:</label>
            <input type="text" name="uname" class="textinput" placeholder="username..." value=${row["username"]}>
            <span class="formerror" id="usernameerror"></span>

            <label>Password:</label>
            <input type="password" name="password" class="textinput" placeholder="password..." value=${row["password"]}>
            <span class="formerror" id="passworderror"></span>

            <label>Email:</label>
            <input type="email" name="email" class="textinput" placeholder="email..." value=${row["email"]}>
            <span class="formerror" id="emailerror"></span>

            <label>Date of Birth</label>
            <input type="date" name="dateofbirth" class="textinput" value=${row["dateofbirth"]}>
            <span class="formerror" id="dateofbirtherror"></span>

            <label>Address:</label>
            <input type="text" name="address" class="textinput" placeholder="address..." value=${row["address"]}>
            <span class="formerror" id="addresserror"></span>

            <label>Status:</label>
            <select name="status-userid" class="textinput" id="status" value=${row["status"]}>
                <option hidden selected>Select an option...</option>
                <option value="Active">Active</option>
                <option value="Inactive">Inactive</option>
                <option value="Banned">Banned</option>
            </select>
            
    `;
    $('div#developer-manage-info').html(html);
    $("#remove-developer-profile-edit-details-box").on("click", function () {
      $("#developer-manage-info").empty();
    });
    $("#save-developer-table-management").on('click', saveDeveloperProfileEditor);
    
}

function loadGames(){
    let xhr = new XMLHttpRequest();
    //query-1
    let query = 'SELECT * FROM game';
    xhr.open('GET', '../../../Hexa/Model/model.php?query='+query, true);
    //xhr.setRequestHeader();
    xhr.send();
    xhr.onreadystatechange = function () {
        if (xhr.readyState == XMLHttpRequest.DONE && xhr.status === 200) {
            //console.log(xhr.responseText);
            let array = JSON.parse(xhr.responseText);
            let html = `
                <tr>
                    <th>Game ID</th>
                    <th>Title</th>
                    <th>Publisher</th>
                    <th>Release Date</th>
                    <th>Status</th>
                    <th></th>
                </tr>
            `;
            for(let row of array){
                html += `
                <tr>
                    <td>${row['gameid']}</td>
                    <td id='${row['gameid']}'>${row['title']}</td>
                    <td>${row['publisher']}</td>
                    <td>${row['releasedate']}</td>
                    <td>${row['status']}</td>
                    <td><span class="material-icons-round">delete</span></td>
                </tr>
                `;  
            }

            $('#game-management-table table').html(html);
            for(let row of array){
                $('#'+row['gameid']).on('click', function(){
                    loadGameDetailsEditor(row);
                });
            }
        }
    }
}

function loadNews(){
    let xhr = new XMLHttpRequest();
    //query-1
    let query = 'SELECT * FROM news';
    xhr.open('GET', '../../../Hexa/Model/model.php?query='+query, true);
    //xhr.setRequestHeader();
    xhr.send();
    xhr.onreadystatechange = function () {
        if (xhr.readyState == XMLHttpRequest.DONE && xhr.status === 200) {
            //console.log(xhr.responseText);
            let array = JSON.parse(xhr.responseText);
            let html = `
                <tr>
                    <th>News ID</th>
                    <th>Title</th>
                    <th>Release Date</th>
                    <th>Status</th>
                    <th></th>
                </tr>
            `;
            for(let row of array){
                html += `
                <tr>
                    <td>${row['newsid']}</td>
                    <td id='${row['newsid']}'>${row['title']}</td>
                    <td>${row['publishdate']}</td>
                    <td>${row['status']}</td>
                    <td><span class="material-icons-round">delete</span></td>
                </tr>
                `;  
            }

            $('#news-management-table table').html(html);
            for(let row of array){
                $('#'+row['newsid']).on('click', function(){
                    loadNewsDetailsEditor(row);
                });
            }
        }
    }
}



function loadCustomer(){
    let xhr = new XMLHttpRequest();
    //query-1
    let query = 'SELECT * FROM USER where usertype="customer"';
    xhr.open('GET', '../../../Hexa/Model/model.php?query='+query, true);
    //xhr.setRequestHeader();
    xhr.send();
    xhr.onreadystatechange = function () {
        if (xhr.readyState == XMLHttpRequest.DONE && xhr.status === 200) {
            //console.log(xhr.responseText);
            let array = JSON.parse(xhr.responseText);
            let html = `
                <tr>
                    <th>Customer ID</th>
                    <th>Customer Name</th>
                    <th>Email</th>
                    <th>Date of Birth</th>
                    <th>Status</th>
                    <th></th>
                </tr>
            `;
            for(let row of array){
                html += `
                <tr>
                    <td>${row['userid']}</td>
                    <td id='${row['userid']}'>${row['firstname']+' '+row['lastname']}</td>
                    <td>${row['email']}</td>
                    <td>${row['dateofbirth']}</td>
                    <td>${row['status']}</td>
                    <td><span class="material-icons-round">delete</span></td>
                </tr>
                `;  
            }

            $('#customer-management-table table').html(html);
            for(let row of array){
                $('#'+row['userid']).on('click', function(){
                    loadCustomerProfileEditor(row);
                });
            }
        }
    }
}

function loadEmployee() {
    let xhr = new XMLHttpRequest();
    //query-2
    let query = 'SELECT * FROM USER where usertype="employee"';
    xhr.open("GET", "../../../Hexa/Model/model.php?query=" + query, true);
    //xhr.setRequestHeader();
    xhr.send();
    xhr.onreadystatechange = function () {
      if (xhr.readyState == XMLHttpRequest.DONE && xhr.status === 200) {
        //console.log(xhr.responseText);
        let array = JSON.parse(xhr.responseText);
        let html = `
                <tr>
                    <th>Employee ID</th>
                    <th>Username</th>
                    <th>Email</th>
                    <th>PaymentID</th>
                    <th>Status</th>
                    <th></th>
                </tr>
            `;
        for (let row of array) {
          html += `
                <tr>
                    <td>${row["userid"]}</td>
                    <td id='${row["userid"]}'>${row["username"]}</td>
                    <td>${row["email"]}</td>
                    <td>${row["paymentid"]}</td>
                    <td>${row["status"]}</td>
                    <td><span class="material-icons-round">delete</span></td>
                </tr>
                `;
        }

        $("#employee-management-table table").html(html);
        for (let row of array) {
          $("#" + row["userid"]).on("click", function () {
            loadEmployeeProfileEditor(row);
          });
        }
      }
    };
}

function loadDeveloper(){
  let xhr = new XMLHttpRequest();
  //query-3
  let query = 'SELECT * FROM USER where usertype="developer"';
  xhr.open("GET", "../../../Hexa/Model/model.php?query=" + query, true);
  //xhr.setRequestHeader();
  xhr.send();
  xhr.onreadystatechange = function () {
    if (xhr.readyState == XMLHttpRequest.DONE && xhr.status === 200) {
      //console.log(xhr.responseText);
      let array = JSON.parse(xhr.responseText);
      let html = `
            <tr>
                <th>Developer ID</th>
                <th>Developer Name</th>
                <th>Email</th>
                <th>Date of Birth</th>
                <th>Status</th>
                <th></th>
            </tr>
        `;
      for (let row of array) {
        html += `
            <tr>
                <td>${row["userid"]}</td>
                <td id='${row["userid"]}'>${
          row["firstname"] + " " + row["lastname"]
        }</td>
                <td>${row["email"]}</td>
                <td>${row["dateofbirth"]}</td>
                <td>${row["status"]}</td>
                <td><span class="material-icons-round">delete</span></td>
            </tr>
            `;
      }
      $("#developer-management-table table").html(html);
      for (let row of array) {
        $("#" + row["userid"]).on("click", function () {
          loadDeveloperProfileEditor(row);
        });
      }
    }
  };
}

function saveGameDetailsEditor()
{
    let title = $('input[name="title"]').val();
    let publisher = $('input[name="publisher"]').val();
    let category = $('input[name="category"]').val();
    let price = $('input[name="price"]').val();
    let discount = $('input[name="discount"]').val();
    let systemrequirment = $('input[name="systemrequirment"]').val();
    let description = $('input[name="description"]').val();
    let releasedate = $('input[name="releasedate"]').val();
    let status = $("#status").val();
    let id = $('#hidden-input').val();
    //query-4
    let query = "UPDATE game SET title='"+title+"',publisher='"+publisher+"',category='"+category+"',price='"+price+"',discount='"+discount+"',releasedate='"+releasedate+"',systemrequirment='"+systemrequirment+"',description='"+description+"',status='"+status+"' WHERE gameid="+id;
    //alert(query);
    let xhr = new XMLHttpRequest();
    xhr.open("GET", "../../../Hexa/Model/model.php?nonquery=" + query, false);
    xhr.send();

    alert("Data Updated");
    $("#remove-customer-profile-edit-details-box").click();
    loadCustomer();
}

function saveNewsDetailsEditor()
{
    let title = $('input[name="title"]').val();
    let domain = $('input[name="domain"]').val();
    let description = $('input[name="description"]').val();
    let publishdate = $('input[name="publishdate"]').val();
    let status = $("#status").val();
    let id = $('#hidden-input').val();
    //query-4
    let query = "UPDATE news SET title='"+title+"',domain='"+domain+"',publishdate='"+publishdate+"',description='"+description+"',status='"+status+"' WHERE gameid="+id;
    //alert(query);
    let xhr = new XMLHttpRequest();
    xhr.open("GET", "../../../Hexa/Model/model.php?nonquery=" + query, false);
    xhr.send();

    alert("Data Updated");
    $("#remove-customer-profile-edit-details-box").click();
    loadCustomer();
}


function saveCustomerProfileEditor()
{
    let fname = $('input[name="fname"]').val();
    let lname = $('input[name="lname"]').val();
    let uname = $('input[name="uname"]').val();
    let email = $('input[name="email"]').val();
    let dob = $('input[name="dateofbirth"]').val();
    let address = $('input[name="address"]').val();
    let region = $('input[name="region"]').val();
    let balance = $('input[name="balance"]').val();
    let pass = $('input[name="password"]').val();
    let country = $('input[name="country"]').val();
    let status = $("#status").val();
    let id = $('#hidden-input').val();
    //query-4
    let query = "UPDATE user SET firstname='"+fname+"',lastname='"+lname+"',username='"+uname+"',password='"+pass+"',email='"+email+"',dateofbirth='"+dob+"',country='"+country+"',region='"+region+"',balance="+balance+",address='"+address+"',status='"+status+"' WHERE userid="+id;
    //alert(query);
    let xhr = new XMLHttpRequest();
    xhr.open("GET", "../../../Hexa/Model/model.php?nonquery=" + query, false);
    xhr.send();

    alert("Data Updated");
    $("#remove-customer-profile-edit-details-box").click();
    loadCustomer();
}

function saveEmployeeProfileEditor()
{
    let fname = $('input[name="fname"]').val();
    let lname = $('input[name="lname"]').val();
    let uname = $('input[name="uname"]').val();
    let email = $('input[name="email"]').val();
    let dob = $('input[name="dateofbirth"]').val();
    let address = $('input[name="address"]').val();
    let country = $('input[name="country"]').val();
    let pass = $('input[name="password"]').val();
    let paymentid = $('input[name="paymentid"]').val();
    let status = $("#status").val();
    let id = $("#hidden-input").val();

    //query-5
    let query = "UPDATE user SET firstname='"+fname+"',lastname='"+lname+"',username='"+uname+"',password='"+pass+"',email='"+email+"',dateofbirth='"+dob+"',country='"+country+"',paymentid="+paymentid+",address='"+address+"',status='"+status+"' WHERE userid="+id;
    //alert(query);
    let xhr = new XMLHttpRequest();
    xhr.open("GET", "../../../Hexa/Model/model.php?nonquery=" + query, false);
    xhr.send();

    alert("Data Updated");
    $("#remove-employee-profile-edit-details-box").click();
    loadEmployee();
}

function saveDeveloperProfileEditor()
{
    
    let uname = $('input[name="uname"]').val();
    let email = $('input[name="email"]').val();
    let dob = $('input[name="dateofbirth"]').val();
    let address = $('input[name="address"]').val();
    let pass = $('input[name="password"]').val();
    let country = $('input[name="country"]').val();
    let paymentid = $('input[name="paymentid"]').val();
    let status = $("#status").val();
    let id = $('#hidden-input').val();

    //query-6
    let query = "UPDATE user SET username='"+uname+"',password='"+pass+"',email='"+email+"',dateofbirth='"+dob+"',country='"+country+"',paymentid='"+paymentid+"',address='"+address+"',status='"+status+"' WHERE userid="+id;
    //alert(query);
    let xhr = new XMLHttpRequest();
    xhr.open("GET", "../../../Hexa/Model/model.php?nonquery=" + query, false);
    xhr.send();
    alert("Data Updated");
    $("#remove-developer-profile-edit-details-box").click();
    loadDeveloper();
}

function loadShowcaseImage()
{
    //query-7
    let query="SELECT type as image from homepage where type not in ('trendingnews', 'trendinggame', 'gamesonsale');"
    let xhr = new XMLHttpRequest();
    xhr.open('GET', '../../../Hexa/Model/model.php?query='+query, true);
    //xhr.setRequestHeader();
    xhr.send();
    xhr.onreadystatechange = function () {
        if (xhr.readyState == XMLHttpRequest.DONE && xhr.status === 200) {
            console.log(xhr.responseText);
            let array = JSON.parse(xhr.responseText);
            $("#showcase-preview").attr("src", array[0].image);
        }
    }
}

function showTrendingGames()
{
    //query-8
    let query="SELECT DISTINCT game.gameid, game.title, game.price, game.discount, game.image, homepage.serial FROM game INNER JOIN homepage ON game.gameid=homepage.gameid ORDER BY serial;";
    let xhr = new XMLHttpRequest();
    xhr.open('GET', '../../../Hexa/Model/model.php?query='+query, true);
    //xhr.setRequestHeader();
    xhr.send();
    xhr.onreadystatechange = function () {
        if (xhr.readyState == XMLHttpRequest.DONE && xhr.status === 200) {
            let array = JSON.parse(xhr.responseText);
            for(let row of array){
                let gameid = row['gameid'];
                let title = row['title'];
                let currentprice = row['price'] - row['price']*(row['discount']/100);
                let mainprice = row['price'];
                let image = row['image'];
                addtrendingGame(gameid, title, currentprice, mainprice, image);
                dragEventHandler('.poster');
            }
            //$("#trending-game-list").html(html);
        }   
    }
}


function showTrendingNews() {
  //query-9
  let query = "SELECT DISTINCT news.newsid, news.title, news.domain, news.image, news.description FROM news INNER JOIN homepage ON news.newsid=homepage.gameid ORDER BY serial ;";
  let xhr = new XMLHttpRequest();
  xhr.open("GET", "../../../Hexa/Model/model.php?query=" + query, true);
  //xhr.setRequestHeader();
  xhr.send();
  xhr.onreadystatechange = function () {
    if (xhr.readyState == XMLHttpRequest.DONE && xhr.status === 200) {
      let array = JSON.parse(xhr.responseText);
      for (let row of array) {
        let newsid = row["newsid"];
        let title = row["title"];
        let description = row['description'];
        let image = row['image'];
        let domain = row['domain'];
        addtrendingNews(newsid, title, domain, image);
        dragEventHandler('.newsbox');
      }
    }
  };
}


function addtrendingNews(newsid, title, domain, image) {
  let html = "";
  html = `
    <div class="newsbox" draggable="true" id="${newsid}">
        <div class="material-icons-round">delete_forever</div>
            <a href="">
                <img src="../Files/img/${image}" alt="">
                <div class="news-box-title">${title}</div>
                <div class="news-box-domain">${domain}</div>
            </a>
        </div>
  `;
  $("#trending-news-list").append(html);
  $("#updatetrendingnewsbutton").on("click", updateTrendingNews);
}


function addtrendingGame(gameid, title, currentprice, mainprice, image)
{
    let html="";
    html = `
        <div class="poster" draggable="true" id="${gameid}">
            <div class="material-icons-round">delete_forever</div>
            <a href="">
                <img src="../Files/img/${image}" alt="">
                <div class="product-details">
                    <div class="product-name">${title}</div>
                    <div class="current-price">$${currentprice}</div>`;
                    if(currentprice!=mainprice)
                        html=html+`<del class="price-before-discount">$${mainprice}</del>`;
    html=html+`</div>
            </a>
        </div>
    `;
    $("#trending-game-list").append(html);
    $("#updatetrendinggamesbutton").on("click", updateTrendingGame);
}

function updateTrendingNews()
{
    let xhr = new XMLHttpRequest();
    //query-7
    xhr.open("GET", "../../../Hexa/Model/model.php?nonquery=DELETE FROM homepage WHERE type='trendingnews';", false);
    xhr.send();

    let array = $(".newsbox");
    var query="";
    for (let i=0; i<array['length'];) {
        console.log(i);
        if(xhr.readyState == XMLHttpRequest.DONE && xhr.status === 200){
            var newsid = parseInt(array[i].attributes.id.nodeValue);
            //query-10
            var query = `INSERT INTO homepage (gameid, type, serial) VALUES (${newsid},'trendingnews',${i});`;
            xhr = new XMLHttpRequest();
            xhr.open("GET", "../../../Hexa/Model/model.php?nonquery=" + query, false);
            xhr.send();
            i++;  
        }
    }
    xhr.onreadystatechange = function () {
        if (xhr.readyState == XMLHttpRequest.DONE && xhr.status === 200) {
            alert("Data Updated");
        }
    }
}


function updateTrendingGame()
{
    let xhr = new XMLHttpRequest();
    xhr.open("GET", "../../../Hexa/Model/model.php?nonquery=DELETE FROM homepage WHERE type='trendinggame';", false);
    xhr.send();

    let array = $(".poster");
    var query="";
    for (let i=0; i<array['length'];) {
      console.log(i);
      if(xhr.readyState == XMLHttpRequest.DONE && xhr.status === 200) {
        var gameid = parseInt(array[i].attributes.id.nodeValue);
        //query-11
        var query=`INSERT INTO homepage (gameid, type, serial) VALUES (${gameid},'trendinggame',${i});`;
        xhr = new XMLHttpRequest();
        xhr.open("GET", "../../../Hexa/Model/model.php?nonquery=" + query, false);
        xhr.send();
        i++;
      }
    }
    xhr.onreadystatechange = function () {
        if (xhr.readyState == XMLHttpRequest.DONE && xhr.status === 200) {
            alert("Data Updated");
        }
    }
}


$("profile-edit-submit-hidden").on('click', function(){
    let fname=$('input[name="fname"]').val();
    let lname=$('input[name="lname"]').val();
    let uname=$('input[name="uname"]').val();
    let email=$('input[name="email"]').val();
    let password=$('input[name="password"]').val();
    let dob=$('input[name="dateofbirth"]').val();
    let address=$('input[name="address"]').val();
    let sql=`UPDATE user SET firstname='${fname}',lastname='${lname}',password='${password}',email='${email}',dateofbirth='${dob}',address='${address}' WHERE username='${uname}'`;
    let xhr = new XMLHttpRequest();
    xhr.open("GET", "../../../Hexa/Model/model.php?fname="+fname+"&lname="+lname+"&email="+email+"uname="+uname+"&address="+address+"&dob="+dob, false);
    xhr.open("GET", "../../../Hexa/Model/model.php?query="+sql  , false);
    xhr.send();
});


function dragEventHandler(classname)
{
    var dragstartid = (dragendid = "");
    var dragstartindex = (dragendindex = 0);
    const draggableItems = $(classname);

    draggableItems.each(function (i) {
      $(this).on("dragstart", function () {
        dragstartid = "#".concat($(this).attr("id"));
        dragstartindex = $(this).index();
      });
      $(this).on("dragover", function (e) {
        e.preventDefault();
      });
      $(this).on("dragenter", function (e) {
        e.preventDefault();
        dragendid = "#".concat($(this).attr("id"));
        dragendindex = $(this).index();
      });
      $(this).on("dragend", function (e) {
        e.preventDefault();
        if (dragstartindex < dragendindex) $(dragendid).after($(dragstartid));
        else $(dragendid).before($(dragstartid));
      });
      $(this).on("drop", function (e) {
        e.preventDefault();
      });
    });
};


