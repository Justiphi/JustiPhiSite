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

    expect(titles).toEqual(['3D Printing', 'IT Support', 'Software Development']);
  });

  it('should promote resin printing', () => {
    expect(fixture.nativeElement.textContent).toContain('High-detail resin 3D printing');
  });
});
