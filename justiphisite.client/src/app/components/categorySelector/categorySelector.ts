import { Component, signal, HostListener, inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Router, RouterLink, RouterLinkActive } from '@angular/router';

@Component({
  selector: 'app-category-selector',
  imports: [RouterLink, RouterLinkActive],
  templateUrl: './categorySelector.html',
  styleUrl: './categorySelector.css',
})

export class CategorySelector {

}
