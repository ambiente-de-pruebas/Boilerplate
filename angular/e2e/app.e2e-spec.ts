import { ProyectoBaseTemplatePage } from './app.po';

describe('ProyectoBase App', function() {
  let page: ProyectoBaseTemplatePage;

  beforeEach(() => {
    page = new ProyectoBaseTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
