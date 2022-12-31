export class Region {
  constructor(data) {
    this.id = data.id
    this.ownerId = data.ownerId
    this.creator = data.creator
    this.regionNumber = data.regionNumber
    this.capital = data.capital
    this.industry = data.industry
    this.agriculture = data.agriculture
  }
}