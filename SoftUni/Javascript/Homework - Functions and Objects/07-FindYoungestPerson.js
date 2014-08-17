function findYoungestPerson(people) {
    var minAge = Number.MAX_VALUE;
    for (var i = 0; i < people.length; i++) {
        if (people[i].age < minAge) {
            var result = people[i];
            minAge = people[i].age;
        }
    }
    if (result) {
        console.log('The youngest person is %s %s', result.firstname, result.lastname);
    } else {
        console.log('Age property is missing');
    }
}
var people = [
    { firstname : 'George', lastname: 'Kolev', age: 32},
    { firstname : 'Bay', lastname: 'Ivan', age: 81},
    { firstname : 'Baba', lastname: 'Ginka', age: 40}];
findYoungestPerson(people);