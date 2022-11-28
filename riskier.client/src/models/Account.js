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
  }
}
