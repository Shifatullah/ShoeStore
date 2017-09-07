import { ShoeStore.BackendPage } from './app.po';

describe('shoe-store.backend App', () => {
  let page: ShoeStore.BackendPage;

  beforeEach(() => {
    page = new ShoeStore.BackendPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
