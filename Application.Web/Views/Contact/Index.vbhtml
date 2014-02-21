@Code
    ViewData("Title") = "Index"
End Code


@*<table class="table table-striped table-bordered table-condensed">
    <tr> 
        <th>First Name</th>
        <th>Last Name</th>
        <th>Email</th>
    </tr>
    <tbody data-bind="foreach: Profiles">
        <tr">
            <td data-bind="text: FirstName"></td>
            <td data-bind="text: LastName"></td>
            <td data-bind="text: Email"></td>
        </tr>
    </tbody>
</table>

<div class='liveExample'> 
    
<form data-bind="submit: addItem">
    New item:
    <input data-bind='value: itemToAdd, valueUpdate: "afterkeydown"' />
    <button type="submit" data-bind="enable: itemToAdd().length > 0">Add</button>
    <p>Your items:</p>
    <select multiple="multiple" width="50" style="width:500px" data-bind="options: items"> </select>
</form>
    
</div>
*@
@*<table>
    <thead>
        <tr><th>First name</th><th>Last name</th></tr>
    </thead>
    <tbody data-bind="foreach: people">
        <tr>
            <td data-bind="text: firstName"></td>
            <td data-bind="text: lastName"></td>
        </tr>
    </tbody>
</table>
 
<script type="text/javascript">
    ko.applyBindings({
        people: [
            { firstName: 'Bert', lastName: 'Bertington' },
            { firstName: 'Charles', lastName: 'Charlesforth' },
            { firstName: 'Denise', lastName: 'Dentiste' }
        ]
    });
</script>*@

 
@* <script src="~/Scripts/Contact.js"></script>
*@



<input type="button"  class="btn btn-small btn-primary"  value="New Contact" data-bind="click:$root.createProfile" />
<hr />
<table class="table table-striped table-bordered table-condensed">
    <tr> 
        <th>First Name</th>
        <th>Last Name</th>
        <th>Email</th>
        <th></th>
    </tr>
    <tbody data-bind="foreach: Profiles">
        <tr>
            <td class="name"><a data-bind="text: FirstName, click: $parent.editProfile"></a></td>
            <td data-bind="text: LastName"></td>
            <td data-bind="text: Email"></td>
            <td><button class="btn btn-mini btn-danger" data-bind="click: $parent.removeProfile">remove</button></td>
        </tr>
    </tbody>
</table>
 
<script src="~/Scripts/Contact.js"></script>