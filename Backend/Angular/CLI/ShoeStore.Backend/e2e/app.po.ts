import { browser, element, by } from 'protractor';

export class ShoeStore.BackendPage {
  navigateTo() {
    return browser.get('/');
  }

  getParagraphText() {
    return element(by.css('app-root h1')).getText();
  }
}
