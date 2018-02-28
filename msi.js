var createMsi = require('msi-packager')

var options = {

    // required 
    source: 'YourNameHere/bin/Release',
    output: 'releases/YourNameHere.msi',
    name: 'YourNameHere',
    upgradeCode: process.env.GUID,
    version: '1.0.1',
    manufacturer: 'Bonny1992',
    iconPath: 'YourNameHere/ynh-icon.ico',
    executable: 'YourNameHere.exe',

    // optional 
    description: "A simple program for Razer Keyboards to dinamically light some keys",
    localInstall: true

}

createMsi(options, function (err) {
    if (err) throw err
    console.log('Outputed to ' + options.output)
})