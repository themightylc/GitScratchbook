import { TestingAngularTemplatePage } from './app.po';

describe('TestingAngular App', function() {
  let page: TestingAngularTemplatePage;

  beforeEach(() => {
    page = new TestingAngularTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
