var DummyProfile = [
    {
        "ProfileId": 1,
        "FirstName": "Anand",
        "LastName": "Pandey",
        "Email": "anand@anandpandey.com"
    },
    {
        "ProfileId": 2,
        "FirstName": "John",
        "LastName": "Cena",
        "Email": "john@cena.com"
    }
];


    var ProfilesViewModel = function () {
        var self = this;
        var refresh = function () {
            self.Profiles(DummyProfile);
        };

        // Public data properties
        self.Profiles = ko.observableArray([]);
        refresh();
    };
    ko.applyBindings(new ProfilesViewModel());



    var SimpleListModel = function (items) {
        this.items = ko.observableArray(items);
        this.itemToAdd = ko.observable("");
        this.addItem = function () {
            if (this.itemToAdd() != "") {
                this.items.push(this.itemToAdd()); // Adds the item. Writing to the "items" observableArray causes any associated UI to update.
                this.itemToAdd(""); // Clears the text box, because it's bound to the "itemToAdd" observable
            }
        } .bind(this);  // Ensure that "this" is always this view model
    };

    ko.applyBindings(new SimpleListModel(["Alpha", "Beta", "Gamma"]));