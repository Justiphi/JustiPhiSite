import { ComponentFixture, TestBed } from '@angular/core/testing';
import { provideRouter } from '@angular/router';
import { Home } from './home';

describe('Home', () => {
  let fixture: ComponentFixture<Home>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Home],
      providers: [provideRouter([])]
    }).compileComponents();

    fixture = TestBed.createComponent(Home);
    fixture.detectChanges();
  });

  it('should create the home page', () => {
    expect(fixture.componentInstance).toBeTruthy();
  });

  it('should list each service area', () => {
    const titles = Array.from<HTMLElement>(fixture.nativeElement.querySelectorAll('article h3'))
      .map((el) => el.textContent?.trim());

    expect(titles).toEqual(['Software Solutions', '3D Printing']);
  });

  it('should promote Layer Zero', () => {
    expect(fixture.nativeElement.querySelector('h1').textContent).toContain('Layer Zero');
  });

  it('should show the availability disclaimer', () => {
    expect(fixture.nativeElement.textContent).toContain('outside standard business hours');
  });
});
