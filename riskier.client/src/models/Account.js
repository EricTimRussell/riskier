export class Account {
  constructor(data) {
    this.id = data.id
    this.email = data.email
    this.name = data.name
    this.picture = data.picture
    this.teamName = data.teamName
    this.totalCapital = data.totalCapital
    this.totalIndustry = data.totalIndustry
    this.totalAgriculture = data.totalAgriculture
    this.infantry = data.infantry
    this.eliteInfantry = data.eliteInfantry
    this.mech = data.mech
    this.ifv = data.ifv
    this.mbt = data.mbt
    this.artillery = data.artillery
    this.ssArtillery = data.ssArtillery
    this.antiAircraft = data.antiAircraft
    this.fighterAircraft = data.fighterAircraft
    this.closeAirSupport = data.closeAirSupport
    this.carrier = data.carrier
    this.cruiser = data.cruiser
    this.destroyer = data.destroyer
    this.transportAircraft = data.transportAircraft
    this.airfield = data.airfield
    this.navalYard = data.navalYard
    this.warehouse = data.warehouse
    this.factory = data.factory
  }
}
